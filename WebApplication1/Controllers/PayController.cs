using Microsoft.AspNetCore.Mvc;
using WebApplication1.Abstractions;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public PayController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentData data)
        {
            try
            {
                // 1. Письмо администратору (вам)
                string adminEmail = "andrey051407@mail.ru";
                string adminSubject = $"Новая аренда: {data.CarModel}";
                string adminBody = $@"
                    <h2>Детали аренды</h2>
                    <p><strong>Клиент:</strong> {data.Name}</p>
                    <p><strong>Email:</strong> {data.Email}</p>
                    <p><strong>Адрес:</strong> {data.Address}, {data.City}</p>
                    <p><strong>Автомобиль:</strong> {data.CarModel}</p>
                    <p><strong>Сумма:</strong> {data.Amount} руб.</p>
                    <p><strong>Получение:</strong> {data.Pickup.Location}, {data.Pickup.Date} {data.Pickup.Time}</p>
                    <p><strong>Возврат:</strong> {data.Dropoff.Location}, {data.Dropoff.Date} {data.Dropoff.Time}</p>
                    <p><strong>Карта:</strong> **** **** **** {data.CardNumber?.Substring(data.CardNumber.Length - 4)}</p>
                ";

                await _emailService.SendAsync(adminEmail, adminSubject, adminBody);

                // 2. Письмо клиенту
                string clientSubject = "Аренда оформлена успешно!";
                string clientBody = $@"
                    <h2>Спасибо за аренду {data.CarModel}!</h2>
                    <p><strong>Сумма:</strong> {data.Amount} руб.</p>
                    <h3>Детали получения:</h3>
                    <p>Место: {data.Pickup.Location}</p>
                    <p>Дата: {data.Pickup.Date} в {data.Pickup.Time}</p>
                    <h3>Детали возврата:</h3>
                    <p>Место: {data.Dropoff.Location}</p>
                    <p>Дата: {data.Dropoff.Date} в {data.Dropoff.Time}</p>
                ";

                await _emailService.SendAsync(data.Email, clientSubject, clientBody);

                return Ok(new { Success = true, Message = "Письма отправлены" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Error = ex.Message
                });
            }
        }
    }
}