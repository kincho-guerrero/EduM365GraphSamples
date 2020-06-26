using System;
using Microsoft.Extensions.Configuration;

namespace AutomatedTeamCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Team Creation Console APP");
            Console.WriteLine("Be sure to have ready your CSV files with the teams and memberships");
            Console.WriteLine("Be sure to modify your template.json in the TeamTemplates folder ");


            var appId = "";
            var scopesString = "User.Read;Calendars.Read";
            var scopes = scopesString.Split(';');

            var authProvider = new DeviceCodeAuthProvider(appId, scopes);

            var accessToken = authProvider.GetAccessToken().Result;

            Console.WriteLine($"Access Token: {accessToken}");

        }
    }
}
