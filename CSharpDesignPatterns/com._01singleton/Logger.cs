using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.com._01singleton
{
    class Logger
	{
        
		private Logger() { }
		private static Logger logger;

		public static Logger GetInstance()
		{
			if (logger == null)
			{


				logger = new Logger();

			}
			return logger;
		}
	}
}
