using FindJob.Fields;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJob.Web.Pages.CVs.CV
{
    public class IndexModel : FindJobPageModel
    {
        public List<SelectListItem> ListIdParent { get; set; }
        public List<SelectListItem> ListCity { get; set; }
        private readonly IFieldRepository _fieldRepository;
        public Guid IdField { get; set; }
        public IndexModel(IFieldRepository fieldRepository)
        {
            _fieldRepository = fieldRepository;
        }
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
            ListIdParent = new List<SelectListItem>();
            ListIdParent.Add(new SelectListItem
            {
                Text = L["Choose"],
                Value = ""
            });
            var items = (await _fieldRepository.GetListAsync());
            if (items.Count > 0)
            {
                ListIdParent.AddRange(
                (items.Select(t => new SelectListItem
                {
                    Text = t.Name,
                    Value = t.Id.ToString()
                }).ToList()
            ));
            }
        }
    }
}
