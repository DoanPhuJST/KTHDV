using KHTHDV.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace QLBH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HanghoaController : ControllerBase
    {
        CSDLBanhang dbc;

        public HanghoaController(CSDLBanhang db)
        {
            dbc = db;
        }

        [HttpPost]
        [Route("/Hanghoa/List")]
        public IActionResult GetList()
        {
            return Ok(new { data = dbc.TblHanghoas.ToList() });
        }

        [HttpPost]
        [Route("/Hanghoa/Insert")]
        public IActionResult ThemHanghoa(string ma, string ten, string donvi, double gianhap, double giaban)
        {
            TblHanghoa hh = new TblHanghoa();
            hh.Id = Guid.NewGuid();
            hh.Ma = ma;
            hh.Ten = ten;
            hh.Donvi = donvi;
            hh.Gianhap = gianhap;
            hh.Giaban = giaban;
            dbc.TblHanghoas.Add(hh);
            dbc.SaveChanges();
            return Ok(new { data = dbc.TblHanghoas.ToList() });
        }

        [HttpPost]
        [Route("/Hanghoa/Update")]
        public IActionResult CapnhatHanghoa(string id, string ma, string ten, string donvi, double gianhap, double giaban)
        {
            TblHanghoa hh = new TblHanghoa();
            hh.Id = new Guid(id);
            hh.Ma = ma;
            hh.Ten = ten;
            hh.Donvi = donvi;
            hh.Gianhap = gianhap;
            hh.Giaban = giaban;
            dbc.TblHanghoas.Update(hh);
            dbc.SaveChanges();
            return Ok(new { hh });
        }

        [HttpPost]
        [Route("/Hanghoa/Delete")]
        public IActionResult Xoa1banghi(string id)
        {
            TblHanghoa hh = new TblHanghoa();
            dbc.TblHanghoas.Remove(hh);
            dbc.SaveChanges();
            return Ok(new { hh });
        }
    }
} 