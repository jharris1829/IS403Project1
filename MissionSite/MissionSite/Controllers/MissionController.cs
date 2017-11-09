using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Mission()
        {
            return View();
        }
        public ActionResult MissionFAQ(string missionName)
        {
            Models.Missions missions = new Models.Missions();

            ViewBag.question1 = "What were some of your favorite foods?";
            ViewBag.question2 = "What do you like about the people?";
            ViewBag.question3 = "What were your favorite areas?";
            ViewBag.question4 = "What items should you pack?";
            ViewBag.question5 = "What was your favorite experience?";

            if (missionName == "Japan Sendai")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "Osamu Sekiguchi";
                missions.MissionAddress = "3-1-5 Yagiyama Minami Taihaiku-ku Sendai - Shi Miyagi - Ken Japan 982 - 0807";
                missions.Language = "Japanese";
                missions.Climate = "Humid subtropical";
                missions.Religion = "Buddism";
                missions.Flag = "~/Content/images/japanFlag.jpg";
                missions.Answer1 = "Ramen!! It is so good!";
                missions.Answer2 = "They are very humble and polite. For the most part they all want to do good.";
                missions.Answer3 = "I loved Misawa, Aomori, Yokote, and Akita. They presented different challenges, but there were so many great relationships made there.";
                missions.Answer4 = "Make sure to bring a nice rain coat along with a winter coat and boots";
                missions.Answer5 = "My favorite experience was when I was able to teach a young family in Yokote who eventually was baptized. I loved seeing how the gospel made such a big impact in their lives.";
            }
            else if (missionName == "Mexico City West")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "Carl Duane Grossen";
                missions.MissionAddress = "Av. Fuente de las Pirámides No.1, Piso 1 Lomas de Tecamachalco 53950 Naucalpan, Estado de Mexico Mexico";
                missions.Language = "Spanish";
                missions.Climate = "Cold and rainy";
                missions.Religion = "Catholicism";
                missions.Flag = "~/Content/images/mexicoFlag.png";
                missions.Answer1 = "Ramen!! It is so good!";
                missions.Answer2 = "They are very humble and polite. For the most part they all want to do good.";
                missions.Answer3 = "I loved Misawa, Aomori, Yokote, and Akita. They presented different challenges, but there were so many great relationships made there.";
                missions.Answer4 = "Make sure to bring a nice rain coat along with a winter coat and boots";
                missions.Answer5 = "My favorite experience was when I was able to teach a young family in Yokote who eventually was baptized. I loved seeing how the gospel made such a big impact in their lives.";
            }
            else if (missionName == "Adriatic North")
            {
                missions.missionName = missionName;
                missions.MissionPresident = "David M. Melonakos";
                missions.MissionAddress = "Svacicev Trg 3/1 10000 Zagreb, Croatia";
                missions.Language = "Serbo-Croatian";
                missions.Climate = "cool, rainy winters and hot, dry summers";
                missions.Religion = "Catholicism";
                missions.Flag = "~/Content/images/croatiaFlag.png";
                missions.Answer1 = "Ramen!! It is so good!";
                missions.Answer2 = "They are very humble and polite. For the most part they all want to do good.";
                missions.Answer3 = "I loved Misawa, Aomori, Yokote, and Akita. They presented different challenges, but there were so many great relationships made there.";
                missions.Answer4 = "Make sure to bring a nice rain coat along with a winter coat and boots";
                missions.Answer5 = "My favorite experience was when I was able to teach a young family in Yokote who eventually was baptized. I loved seeing how the gospel made such a big impact in their lives.";
            }
            return View(missions);
        }
    }
}