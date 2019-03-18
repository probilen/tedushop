using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        String MetaKeyword { get; set; }
        String MetaDescription { get; set; }
        DateTime? CreateDate { get; set; }
        String CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        String UpdateBy { get; set; }
        Boolean Status { get; set; }
    }
}