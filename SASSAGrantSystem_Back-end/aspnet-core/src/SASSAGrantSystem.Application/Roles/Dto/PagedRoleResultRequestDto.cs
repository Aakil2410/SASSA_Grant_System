﻿using Abp.Application.Services.Dto;

namespace SASSAGrantSystem.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

