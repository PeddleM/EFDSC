using EFDSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDSC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Announcement> announcements = new List<Announcement>();
            announcements.Add(new Announcement("ASA East Region Open Water Championships", "Swimming the Novice 800m event were Jamie Levy and Maxwell Jones. Both coped well with the weeds in the water and Maxwell was rewarded with a Silver medal for being the 2nd placed Essex swimmer.", DateTime.Now));
            announcements.Add(new Announcement("City of Cambridge SC Gala", "Congratualtions to all the EFDSC swimmers who attended one or more of the sessions at this long day in Cambridge. The Head Coach reported that there were a large number of PBs, a few new county times and a clutch of medals won by Epping swimmers.", DateTime.Now));

            ViewBag.Announcements = announcements;

            List<ExternalLink> links = new List<ExternalLink>();
            links.Add(new ExternalLink("Epping Sep 27 Season Opener", "/Home/Contacts"));
            links.Add(new ExternalLink("Summer timetable", "/Home/Contacts"));
            links.Add(new ExternalLink("Squad timetable effective Sept 1", "/Home/Contacts"));
            links.Add(new ExternalLink("Essex County Info Pack 2016", "/Home/Contacts"));
            links.Add(new ExternalLink("Sun Schedule 2015 - Mar to Jul", "/Home/Contacts"));

            ViewBag.Links = links;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("Clare Tompkins", "Club Shop", "clarentel@ntlworld.com", ""));
            contacts.Add(new Contact("Fiona Jones", "Secretary", "secretary.efdsc@outlook.com", ""));
            contacts.Add(new Contact("Jacque Beer", "Welfare Officer", "efdscwelfare@outlook.com", ""));
            contacts.Add(new Contact("James Clifford", "Treasurer", "efdsc.payments@yahoo.co.uk", ""));
            contacts.Add(new Contact("Julie Bibby", "Gala Secretary", "galasec@efdsc.org", ""));
            contacts.Add(new Contact("Suzanne Peddle", "Club Shop", "peddle.family@ntlworld.com", "01992815103"));
            contacts.Add(new Contact("Suzanne Peddle", "Membership Secretary", "membership@efdsc.org", "01992815103"));

            ViewBag.Contacts = contacts;

            return View();
        }
    }
}