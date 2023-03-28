using net_core_api_push_notification_demo.Models;

namespace net_core_api_push_notification_demo.Service
{
    public interface INotificationService
    {
        Task<ResponseModel> SendNotification(NotificationModel notificationModel);
    }
}
