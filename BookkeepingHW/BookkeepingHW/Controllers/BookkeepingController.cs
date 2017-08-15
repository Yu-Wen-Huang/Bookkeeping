using BookkeepingHW.Models.ViewModels;
using BookkeepingHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;


namespace BookkeepingHW.Controllers
{
    public class BookkeepingController : Controller
    {
        private int pageSize = 10;
        private List<ListViewModel> data = new List<ListViewModel>();
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        private int pageNum = 1;

        // GET: Bookkeeping
        public ActionResult Index(int? page)
        {
            pageNum = page ?? 1;
            return View();
        }
        
        public ActionResult BookkeepingList(int? page)
        {
            var accountList = db.AccountBook.Select(x => new ListViewModel
            {
                Category = x.Categoryyy.ToString(),
                Date = x.Dateee,
                Amount = x.Amounttt,
                Memo = x.Remarkkk
            });
            data = accountList.OrderBy(d => d.Date).ToList();
            //var accountList = db.AccountBook.OrderBy(d => d.Dateee).ToList();
            //foreach (var item in accountList)
            //{
            //    ListViewModel obj = new ListViewModel();
            //    obj.Category = item.Categoryyy.ToString();
            //    obj.Date = item.Dateee;
            //    obj.Amount = item.Amounttt;
            //    obj.Memo = item.Remarkkk;
            //    data.Add(obj);
            //}

            pageNum = page ?? 1;

            var onePageOfList = data.ToPagedList(pageNum, pageSize);

            return View(onePageOfList);
        }
    }
}