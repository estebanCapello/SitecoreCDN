using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.HttpRequest;
using Sitecore.Resources.Media;
using NTTData.SitecoreCDN.Providers;
using Sitecore.Pipelines;
using NTTData.SitecoreCDN.Configuration;

namespace NTTData.SitecoreCDN.Pipelines
{
    /// <summary>
    /// Injects the CDN replacement media provider into the MediaManager
    /// </summary>
    public class ReplaceMediaProvider
    {
        public void Process(PipelineArgs args)
        {
            //Commented due error on sitecore 8.2 update 1
            //This configuration needs to be done on the sitecore.config file 
            //node: mediaProvider

            //Assert.ArgumentNotNull(args, "args");
            //if (CDNSettings.Enabled)
            //    MediaManager.MediaProvider = new CDNMediaProvider();
        }
    }
}
