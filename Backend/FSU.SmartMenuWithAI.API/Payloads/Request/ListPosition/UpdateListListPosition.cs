﻿using FSU.SmartMenuWithAI.Service.Models.ListPosition;
using System.ComponentModel.DataAnnotations;

namespace FSU.SmartMenuWithAI.API.Payloads.Request.ListPosition
{
    public class UpdateListListPosition
    {
        [Required(ErrorMessage = "Thiếu brandID")]
        [Range(1, int.MaxValue, ErrorMessage = "Số không hợp lệ.")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Thiếu danh sách chi tiết")]
        public List<ListDetailUpdate>? ListDetails { get; set; }
    }
}