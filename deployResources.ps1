param (
    [Parameter(Mandatory = $true)] [string] $resourceGroupName,
    [Parameter(Mandatory = $false)] [string] $prefix,
    [Parameter(Mandatory = $false)] [string] $sqlAdminUsername,
    [Parameter(Mandatory = $false)] [string] $sqlAdminPassword
)

#Gets the ARM template file
Write-Host "Getting ARM template file..."
$TemplateLocation = Join-Path  $PSScriptRoot "resources.json"
if($null -eq $TemplateLocation) {
    throw "No ARM template file was found in path $TemplateFile"
} else {
    Write-Host "OK" -ForegroundCoor Green
}

# Set of parameters for ARM template. 
$Parameters = @{ } #hashtable = collection of name-value pairs
$Parameters.Add("prefix", $prefix)
$Parameters.Add("sqlAdminUsername", $sqlAdminUsername)
$Parameters.Add("sqlAdminPassword", $sqlAdminPassword)


$Deployment = New-AzResourceGroupDeployment  -resourceGroupName $resourceGroupName -TemplateFile $TemplateLocation -Mode Incremental -TemplateParameterObject $Parameters -Verbose

#Saving outputs variables from ARM template
Write-Host "##vso[task.setvariable variable=serverName]$($Deployment.Outputs["serverName"].Value)"
Write-Host "##vso[task.setvariable variable=sqlDBName]$($Deployment.Outputs["sqlDBName"].Value)"
Write-Host "##vso[task.setvariable variable=functionName]$($Deployment.Outputs["functionName"].Value)"