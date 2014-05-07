using System;
using System.Dynamic;
<<<<<<< HEAD
using NOCQ.Settings;
=======
using System.Linq;
>>>>>>> e5ed166572b47afde75d47f888768ae5b8d528f2
using NOCQ.Plugins.Email;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NOCQ.Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Parse the settings file
			var json = System.IO.File.ReadAllText ("settings.json");
			var settings = SettingsParser.Parse (json);

			// Load the settings for the email plugin
			var email = settings.InputPlugins.Single (x => x.Name == "Email");
			var emailSettings = email.Settings;

			//.Create and start an email plugin instance
			var emailPlugin = new ImapInput(emailSettings);
			emailPlugin.Execute(null,null);

			Console.ReadKey ();
/*
			var list = new List<Alert>();
			for (var i = 0; i < 3000; i++)
			{
				var al = new Alert()
				{Data = "data" + Guid.NewGuid(), Runbook = "runbook", Service = "service",
					Severity = "sev",
					Source = "Source",
					System = "System",
					TimeStamp = new DateTime(2011,1,1)
				};
				list.Add(al);
			}
			list.ForEach(al => RedisDatabase.SaveAlert(al, "127.0.0.1", RedisQueues.Input, 6379, 3000));
			for (var i = 0; i < 3000; i++)
			{
				var s = RedisDatabase.GetNextAlert("127.0.0.1", RedisQueues.Input, 6379, 3000);
				Console.WriteLine(s.Data);
			}

			Console.ReadLine();
		
*/
		}
	}
}
