using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginForm.Business
{
    public interface IDataResult<out T> 
    {
        bool Success { get; }
        string Message { get; }
        T Data { get; }
    }
}
