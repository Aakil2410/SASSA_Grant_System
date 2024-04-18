using System.Threading.Tasks;
using SASSAGrantSystem.Models.TokenAuth;
using SASSAGrantSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace SASSAGrantSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: SASSAGrantSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}