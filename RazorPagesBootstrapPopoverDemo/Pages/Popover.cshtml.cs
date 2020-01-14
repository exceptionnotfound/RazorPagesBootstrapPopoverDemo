using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBootstrapPopoverDemo
{
    public class PopoverModel : PageModel
    {
        public List<string> Messages { get; set; }
        public void OnGet()
        {
            Messages = new List<string>()
            {
                "Turns out NASA can't even improve on duct tape... Duct tape is magic and should be worshipped.",
                "How come Aquaman can control whales? They're mammals! Makes no sense.",
                "As with most of life's problems, this one can be solved by a box of pure radiation."
            };
        }
    }
}