using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureOps_SampleApp.Pages
{
    public class MemoryPercentageUpModel : PageModel
    {
        private readonly ILogger<MemoryPercentageUpModel> _logger;

        public MemoryPercentageUpModel(ILogger<MemoryPercentageUpModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            // �������g�p�ʂ��Ӑ}�I�ɏグ��
            var list = new List<string>();
            // ���O�ɏo�͂����
            _logger.LogInformation("�������g�p�����Ӑ}�I�ɏ㏸�����܂�");
            while (true)
            {
                list.Add("�����������������������������������Ă�");
            }
        }
    }
}