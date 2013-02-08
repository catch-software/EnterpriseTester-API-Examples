using System;
using Castle.Core.Logging;
using EnterpriseTester.Common.Plugins;
using EnterpriseTester.Core.Licensing;
using EnterpriseTester.Core.Models;
using EnterpriseTester.Core.Security;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class EnterpriseTesterRaygunMessageBuilderFactory
    {
        readonly ILicenseManager _licenseManager;
        readonly IUserContext _userContext;
        ILogger _logger = NullLogger.Instance;

        public EnterpriseTesterRaygunMessageBuilderFactory(IUserContext userContext, ILicenseManager licenseManager)
        {
            if (userContext == null) throw new ArgumentNullException("userContext");
            if (licenseManager == null) throw new ArgumentNullException("licenseManager");
            _userContext = userContext;
            _licenseManager = licenseManager;
        }

        public ILogger Logger
        {
            get { return _logger; }
            set { _logger = value; }
        }

        public EnterpriseTesterRaygunMessageBuilder CreateBuilder()
        {
            return new EnterpriseTesterRaygunMessageBuilder()
                .SetLicense(TryGetCurrentLicense())
                .SetUser(TryGetCurrentUser());
        }

        User TryGetCurrentUser()
        {
            try
            {
                return _userContext.CurrentUser;
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to get current user", ex);
            }

            return null;
        }

        LicenseDetails TryGetCurrentLicense()
        {
            try
            {
                return _licenseManager.GetCurrentLicense();
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to get current license", ex);
            }

            return null;
        }
    }
}