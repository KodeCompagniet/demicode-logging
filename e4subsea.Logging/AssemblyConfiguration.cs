using log4net.Config;


/*
 * This attrbiute makes sure we load log4net configuration when needed.
 */
[assembly: XmlConfigurator(ConfigFile = "log4net.config")]
