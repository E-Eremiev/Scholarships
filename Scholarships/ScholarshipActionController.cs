using System;

namespace Scholarships
{

    public class ScholarshipActionController
    {
        public ScholarshipActionController()
        {

            ScholarshipView view = new ScholarshipView();
            ScholarshipModel model = new ScholarshipModel();
            Console.Write("Въведи Доход: ");
            model.Income = view.Input();
            Console.Write("Въведи оценка: ");
            model.Grade = view.Input();
            Console.Write("Въведи минимална работна заплата: ");
            model.MinSalary = view.Input();

            bool hasSocial = model.Income < model.MinSalary && model.Grade > 4.5;
            bool hasExcellent = model.Grade >= 5.5;
            double socialAmount = model.MinSalary * 0.35;
            double excellentAmount = model.Grade * 25;

            Console.WriteLine("==============================================");

            if (!hasSocial && !hasExcellent)
            {
                view.NeSeVpisva();
            }
            else if (hasSocial && !hasExcellent)
            {
                view.SocialnaStipendia((int)socialAmount);
            }
            else if (!hasSocial && hasExcellent)
            {
                view.ZaOtlichenUspeh((int)excellentAmount);
            }
            else
            {
                if (excellentAmount >= socialAmount)
                {
                    view.ZaOtlichenUspeh((int)excellentAmount);
                }
                else
                {
                    view.SocialnaStipendia((int)socialAmount);
                }
            }

        }

    }
}


