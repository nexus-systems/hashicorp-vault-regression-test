using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashicorpVaultRegressionTest.Authentication
{
    [TestClass]
    [TestCategory("Authentication")]
    public class AppRole
    {
        protected static TestContext _context;

        [ClassInitialize]
        public static void InitClass(TestContext context)
        {
            _context = context;
        }

        [TestMethod("AppRole Basic Lifecycle")]
        public async Task AppRoleBasicLifecycleAsync()
        {

        }

        private async Task ListApproleAsync()
        {

        }

        private async Task CreateUpdateAppRoleAsync()
        {

        }

        private async Task ReadAppRoleAsync()
        {

        }

        private async Task DeleteAppRoleAsync()
        {

        }
    }
}
