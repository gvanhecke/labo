using Affilia.Api.Business.DTO;
using Affilia.Api.Data.Models;

namespace Affilia.Api.Tests
{
    public class Given
    {

    }

    public class When
    {

    }

    public class Then
    {
        public void MyFistTestCase()
        {
            var parent = new Parent();
            var dto = parent.Map();
        }
    }
}