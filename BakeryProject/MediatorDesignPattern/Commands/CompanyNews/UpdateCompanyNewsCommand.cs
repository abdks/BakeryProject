﻿namespace BakeryProject.MediatorDesignPattern.Commands.CompanyNews
{
    public class UpdateCompanyNewsCommand
    {
        public int CompanynewsID { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
}
