using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View.Components.Models;

namespace View.Components.ViewComponents
{
    public class PriorityListViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(string param)
        {
            var items = GetItems(param);
            return View(items);
        }

        private List<TodoItemViewModel> GetItems(string param)
        {
            var items = new List<TodoItemViewModel>()
            {
                new TodoItemViewModel {Id = 1, Title = $"Todo: {param}"},
            };

            return items;
        }
    }
}
