using HW.Lesson1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW.Lesson1.Controllers
{
    public class CompanyController : Controller
    {
        private List<Product> products = new List<Product>();
        public CompanyController()
        {
            products.Add(new Product("ARO Сахар-песок 800 г", "Сахар ARO изготавливается на современном оборудовании по классической технологии посредством отжима патоки из свеклы", "kz_pim_137056001001_01.png", "kz_pim_137056001001_01.png", 100, 495));
            products.Add(new Product("FINE LIFE Губка меламиновая 2 шт", "2ШТ ГУБКА МЕЛАМИНОВАЯ FL БЕЛЫЙ Страна происхождения: CN-КИТАЙ", "kz_pim_120999001001_01.png", "kz_pim_120999001001_01.png", 100, 249));
            products.Add(new Product("ARO Крабовые палочки замороженные 100 г", "Крабовые палочки ARO замороженные, 100г – это наслаждение для гурманов, кроме изысканного вкуса оно еще и очень полезное", "kz_pim_119476001001_01.png", "kz_pim_119476001001_01.png", 100, 459));
            products.Add(new Product("120ШТ ARO ВАТНЫЕ ДИСКИ", "120ШТ ARO ВАТНЫЕ ДИСКИ Страна происхождения: RU-РОССИЯ", "kz_pim_20263001004_01.png", "kz_pim_20263001004_01.png", 100, 599));
            products.Add(new Product("FINE LIFE Кукуруза сладкая ж/б 425 мл", "100% натуральные кукурузные зерна с добавлением соли, сахара и воды.", "", "", 100, 843));
            products.Add(new Product("КОНТЕЙНЕР GN 1/9 ИЗ ПОЛИПРОПИЛЕНА С КРЫШКОЙ 6,5 СМ", "КОНТЕЙНЕР GN 1/9 ИЗ ПОЛИПРОПИЛЕНА С КРЫШКОЙ 6,5 СМ", "", "", 100, 2699));
        }

        public IActionResult Production()
        {

            return View(products);
        }

        public IActionResult Images()
        {
            return View(products.Where(w=> w.PathSmallImage!= "default-image_450.png").ToList());
        }
    }
}
