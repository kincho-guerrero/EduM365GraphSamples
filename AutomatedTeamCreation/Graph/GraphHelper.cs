using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutomatedTeamCreation
{
    public class GraphHelper
    {
        private static GraphServiceClient graphclient;
        public static void Initialize(IAuthenticationProvider authProvider)
        {
            graphclient = new GraphServiceClient(authProvider);
        }

    }
}