﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorise;
using EasyAbp.AbpHelper.Gui.Solutions;
using EasyAbp.AbpHelper.Gui.Solutions.Dtos;
using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Volo.Abp.BlazoriseUI.Components;

namespace EasyAbp.AbpHelper.Gui.Pages.Solutions
{
    public partial class Index
    {
        [Inject]
        private IStringLocalizer<AbpUiResource> UiLocalizer { get; set; }

        private DataGridEntityActionsColumn<SolutionDto> EntityActionsColumn { get; set; }

        protected virtual string GetDeleteConfirmationMessage(SolutionDto solution)
        {
            return UiLocalizer["ItemWillBeDeletedMessage"];
        }
    }
}
