using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // 1
            ViewBag.AllWomensLeagues = _context.Leagues
            .Where(l=> l.Name.Contains("Womens"))
            .ToList();
            // 2
            ViewBag.AllHockeyLeagues = _context.Leagues
            .Where(l=> l.Name.Contains("Hockey"))
            .ToList();
            // 3
            ViewBag.AllNotFootballLeagues = _context.Leagues
            .Where(l=> !l.Sport.Contains("Football"))
            .ToList();

            ViewBag.AllConferenceLeagues = _context.Leagues
            .Where(l=> l.Name.Contains("Conference"))
            .ToList();

            ViewBag.AllAtlanticLeagues = _context.Leagues
            .Where(l=> l.Name.Contains("Atlantic"))
            .ToList();

            ViewBag.AllDallasTeams = _context.Teams
            .Where(t=> t.Location.Contains("Dallas"))
            .ToList();

            ViewBag.AllRaptorsTeams = _context.Teams
            .Where(t=> t.TeamName.Contains("Raptors"))
            .ToList();

            ViewBag.AllCityTeams = _context.Teams
            .Where(t=> t.Location.Contains("City"))
            .ToList();

            ViewBag.AllStartWithTTeams = _context.Teams
            .Where(t=> t.TeamName.StartsWith("T"))
            .ToList();

            ViewBag.AllTeamsByLocation = _context.Teams
            .OrderBy(t=> t.Location)
            .ToList();

            ViewBag.AllTeamsByReverse = _context.Teams
            .OrderByDescending(t=> t.TeamName)
            .ToList();

            ViewBag.PlayersWithLastName = _context.Players
            .Where(t=> t.LastName == "Cooper")
            .ToList();

            ViewBag.PlayersWithFirstName = _context.Players
            .Where(t=> t.FirstName == "Joshua")
            .ToList();

            ViewBag.PlayersFandL = _context.Players
            .Where(t=> t.LastName == "Cooper" && t.FirstName != "Joshua")
            .ToList();

            ViewBag.PlayersForF = _context.Players
            .Where(t=> t.FirstName == "Alexander" || t.FirstName == "Wyatt")
            .ToList();

            return View();

        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            ViewBag.AllAtlanticTeams= _context.Leagues.Include(t=> t.Teams).Where(l=>l.Name.Contains("Atlantic Soccer Conference")).ToList();

            ViewBag.CurrentBostenPlayers = _context.Teams.Include(p=> p.CurrentPlayers).Where(t=>t.Location=="Boston" && t.TeamName =="Penguins").ToList();

            // ViewBag.CurrentInterBCPlayers = _context.Leagues.Include(t=>t.Teams).Where(l=>l.Name =="International Collegiate Baseball Conference").Include(p=>p.CurrentPlayers).ToList();
            
            ViewBag.CurrentInterBCPlayers = _context.Teams.Include(l=>l.CurrLeague).
            Where(l=>l.CurrLeague.Name=="International Collegiate Baseball Conference").
            Include(p=> p.CurrentPlayers).ToList();

            // ViewBag.CurrentACAFPlayersL = _context.Teams.Include(l=>l.CurrLeague).
            // Where(l=>l.CurrLeague.Name=="American Conference of Amateur Football").
            // Include(p=> p.CurrentPlayers).Where(p=>p.CurrentPlayers.LastName=="").ToList();
            
            ViewBag.CurrentACAFPlayersL = _context.PlayerTeams
            .Include(p => p.PlayerOnTeam)
            .Include(l => l.TeamOfPlayer.CurrLeague)  
            .Where(all => all.TeamOfPlayer.CurrLeague.Name == "American Conference of Amateur Football" 
            && all.PlayerOnTeam.LastName == "Lopez"
            )
            .ToList();

            ViewBag.FootballPlayers = _context.Players.Include(t=>t.CurrentTeam.CurrLeague)
            .Where(l=>l.CurrentTeam.CurrLeague.Sport=="Football");

            ViewBag.SophiaPlayers = _context.Players.Include(t=>t.CurrentTeam.CurrentPlayers)
            .Where(p=>p.FirstName=="Sophia");

            ViewBag.SophiaLeague = _context.Players.Include(t=>t.CurrentTeam.CurrLeague)
            .Where(p=>p.FirstName=="Sophia");

            ViewBag.AllNoWR = _context.Players.Include(t=>t.CurrentTeam)
            .Where(p=>p.LastName=="Flores" && p.CurrentTeam.Location!="Washington" && p.CurrentTeam.TeamName!="Roughriders");

            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}