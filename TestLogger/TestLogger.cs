using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace Logger
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class TestLogger
    {
        /// <summary>
        /// This method tries to add a new entry in the log
        /// </summary>
        [TestMethod]
        public void Logger_WriteMessageLog_MessageWithoutTimestamp_success()
        {
            //given
            DateTime currentDate = DateTime.Now;//récupérer la date courante
            string currentDateString = currentDate.ToString("yyyyMMdd");
            Logger logger = new Logger(Directory.GetCurrentDirectory(), currentDateString); //Un objet de type Logger qui sera utilisé pour les tests
            string expectedMessage = "Le formulaire n'est pas complet !";//Un message à inscrire dans le logger
            string expectedLevel = "Warning";//Un niveau d'information
            string actualMessage = "";
            string actualLevel = "";

            List<string> actualLogContent = null;

            logger.WriteEntry(expectedLevel, expectedMessage);//on écrit un message dans le log

            //when
            actualLogContent = logger.Content;//je récupère le contenu du log

            //then
            //extraction du message
            string[] actualLogContentSplitted = actualLogContent[0].Split('\t');
            actualLevel = actualLogContentSplitted[1];
            actualMessage = actualLogContentSplitted[2];
            Assert.AreEqual(expectedLevel, actualLevel);//on teste le niveau
            Assert.AreEqual(expectedMessage, actualMessage);//on teste le message
            //TODO tester la date (en supprimant les secondes)
        }
    }
}
