using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapi.Models;

namespace shopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductController : ControllerBase
    {
        [HttpPost]
        public testPost Post([FromBody] Order order)
        {
            // หาสินค้าที่ผู้ใช้เลือกซื้อว่ามีหรือเปล่า
            var findingProduct = new ProductController();
            var finding = findingProduct.GetProduct();
            var selectProduct = finding.FirstOrDefault(it => it.Id == order.Id);

            // ไม่มีสินค้าที่ผู้ใช้เลือก ไม่ทำต่อ
            if (selectProduct == null)
            {
                var unknowtext = new testPost
                {
                    text = "ไม่พบรหัสสินค้า"
                };

                return unknowtext;
            }
            else
            {
                var knowtext = new testPost
                {
                    text = "พบรหัสสินค้า"
                };

                return knowtext;
            }

            // มีสินค้าที่ผู้ใช้เลือก ทำการบันทึกประวัติการสั่งซื้อ
        }
    }
}