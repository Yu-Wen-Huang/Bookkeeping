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

        private int pageNum = 1;

        // GET: Bookkeeping
        public ActionResult Index(int? page)
        {
            pageNum = page ?? 1;
            return View();
        }
        
        public ActionResult BookkeepingList(int? page)
        {
            data.Add(new ListViewModel
            {
                Category = "收入",
                Date = DateTime.Today,
                Amount = 100,
                Memo = "eat"
            });

            pageNum = page ?? 1;

            var onePageOfList = data.ToPagedList(pageNum, pageSize);

            return View(onePageOfList);
        }
    }
}