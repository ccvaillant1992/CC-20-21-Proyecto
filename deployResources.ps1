param (
    [Parameter(Mandatory = $true)] [string] $ResourceGroupName,
    [Parameter(Mandatory = $false)] [string] $resourcePrefix,
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
$Parameters.Add("resourcePrefix", $resourcePrefix)
$Parameters.Add("sqlAdminUsername", $sqlAdminUsername)
$Parameters.Add("sqlAdminPassword", $sqlAdminPassword)

$Deployment = New-AzResourceGroupDeployment  -ResourceGroupName $ResourceGroupName -TemplateFile $TemplateLocation -Mode Incremental -TemplateParameterObject $Parameters -Verbose

