﻿namespace AplicacionMVC.ViewModels
{
    public class NoticeFormVM
    {
         public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile UrlImage { get; set; }
    }
}
