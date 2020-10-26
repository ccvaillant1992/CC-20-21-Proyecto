using System;
using Xunit;
using WebApplication1.Models;

namespace Catalogo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void emptyErrorViewModelReturnsFalseShowRequestId()
        {
            ErrorViewModel objectTest = new ErrorViewModel();
            Assert.False(objectTest.ShowRequestId);
        }

    }
}
