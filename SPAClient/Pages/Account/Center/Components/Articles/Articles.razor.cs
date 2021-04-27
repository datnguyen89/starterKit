using System.Collections.Generic;
using SPAClient.Models;
using Microsoft.AspNetCore.Components;

namespace SPAClient.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}