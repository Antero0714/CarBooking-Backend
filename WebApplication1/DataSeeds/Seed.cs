//using WebApplication1.Enums;
//using WebApplication1.Models;

//namespace WebApplication1.DataSeets
//{
//    public static class Seed
//    {
//        public static List<Car> Cars = new List<Car>()
//        {
//            new Car()
//            {
//                id = 1,
//                Name = "Nissan GT-R",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0f4c9df4f558109ad20248cf1a2ed07b_ELANTRA.png",
//                Description = "Спортивный автомобиль премиум-класса",
//                Price = 500,
//                Transmissions = "Manual",
//           Type = CarType.Sport,
//                Fuel = "90L",
//                Capacity = "2 Person",
//                Comments = new[]
//                {
//                    "Отличный выбор!",
//                    "Быстрый и надежный."
//                }
//            },
//            new Car() {
//                id = 6,
//                Name = "Hyundai Solaris (2014)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0065c70e192baafbed5fd4118ff19cf1_SONATA.png",
//                Description = "Компактный седан",
//                Price = 45.00m,
//                Transmissions = "Manual",
//                Type = CarType.Sedan,
//                Fuel = "85L",
//                Capacity = "4 Person",
//                Comments = new[] {
//                    "Хорошая бюджетная машина.",
//                    "Экономичный расход топлива."
//                }
//            },
//            new Car() {
//                id = 7,
//                Name = "Hyundai Solaris (2018)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/73b717776f26594ad721ec152838c19d_creta2_conf.png",
//                Description = "Современный дизайн",
//                Price = 50.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "90L",
//                Capacity = "4 Person",
//                Comments = new[] {
//                    "Удобен в городских условиях.",
//                    "Просторный салон."
//                }
//            },
//            new Car() {
//                id = 8,
//                Name = "Hyundai Solaris (2022)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/148c8e3342e8cef7bf71fcd1f2c19b2e_TUCSON.png",
//                Description = "Экономичный и удобный",
//                Price = 55.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "95L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Отличная управляемость.",
//                    "Стильный внешний вид."
//                }
//            },
//            new Car() {
//                id = 12,
//                Name = "Hyundai Elantra (2015)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/1b5d5afe690d8fcced0b012c4a7fbd74_PALISADE.png",
//                Description = "Классический седан",
//                Price = 48.00m,
//                Transmissions = "Manual",
//                Type = CarType.Sedan,
//                Fuel = "88L",
//                Capacity = "4 Person",
//                Comments = new[] {
//                    "Надежный и удобный.",
//                    "Просторный багажник."
//                }
//            },
//            new Car() {
//                id = 13,
//                Name = "Hyundai Elantra (2019)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/dde24f691dc7a5aa10acd4fb535ad82a_Staria.png",
//                Description = "Обновленный дизайн",
//                Price = 53.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "93L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Хорошая шумоизоляция.",
//                    "Комфортные сиденья."
//                }
//            },
//            new Car() {
//                id = 18,
//                Name = "Hyundai Sonata (2013)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0f4c9df4f558109ad20248cf1a2ed07b_ELANTRA.png",
//                Description = "Базовая модель",
//                Price = 50.00m,
//                Transmissions = "Manual",
//                Type = CarType.Sedan,
//                Fuel = "90L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Простая и надежная.",
//                    "Доступный ремонт."
//                }
//            },
//            new Car()
//            {
//                id = 19,
//                Name = "Hyundai Sonata (2017)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/dde24f691dc7a5aa10acd4fb535ad82a_Staria.png",
//                Description = "Комфортный и стильный",
//                Price = 55.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "95L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Отличный семейный авто.",
//                    "Плавный ход."
//                }
//            },
//            // Добавленные модели для полноты
//            new Car()
//            {
//                id = 24,
//                Name = "Hyundai Tucson",
//                image = "https://api.configurator.hyundai.ru/images/car_type/dde24f691dc7a5aa10acd4fb535ad82a_Staria.png",
//                Description = "Популярный кроссовер",
//                Price = 60.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "100L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Универсальный выбор.",
//                    "Хорошая проходимость."
//                }
//            },
//            new Car()
//            {
//                id = 27,
//                Name = "Hyundai Santa Fe",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0f4c9df4f558109ad20248cf1a2ed07b_ELANTRA.png",
//                Description = "Большой семейный SUV",
//                Price = 70.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "110L",
//                Capacity = "7 Person",
//                Comments = new[] {
//                    "Просторный салон.",
//                    "Надежный двигатель."
//                }
//            },
//            new Car()
//            {
//                id = 30,
//                Name = "Hyundai Creta (2020)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/73b717776f26594ad721ec152838c19d_creta2_conf.png",
//                Description = "Компактный кроссовер",
//                Price = 65.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "95L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Стильный дизайн",
//                    "Экономичный расход"
//                }
//            },
//            new Car()
//            {
//                id = 31,
//                Name = "Hyundai Palisade (2021)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/1b5d5afe690d8fcced0b012c4a7fbd74_PALISADE.png",
//                Description = "Флагманский SUV",
//                Price = 85.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "120L",
//                Capacity = "7 Person",
//                Comments = new[] {
//                    "Премиальное качество",
//                    "Просторный салон"
//                }
//            },
//            new Car()
//            {
//                id = 32,
//                Name = "Hyundai Staria (2022)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/dde24f691dc7a5aa10acd4fb535ad82a_Staria.png",
//                Description = "Минивэн премиум-класса",
//                Price = 75.00m,
//                Transmissions = "Automatic",
//                Type = CarType.MPV,
//                Fuel = "115L",
//                Capacity = "8 Person",
//                Comments = new[] {
//                    "Невероятный комфорт",
//                    "Инновационный дизайн"
//                }
//            },
//            new Car()
//            {
//                id = 33,
//                Name = "Hyundai Tucson (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/148c8e3342e8cef7bf71fcd1f2c19b2e_TUCSON.png",
//                Description = "Обновленный кроссовер",
//                Price = 72.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "105L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Современные технологии",
//                    "Отличная управляемость"
//                }
//            },
//            new Car()
//            {
//                id = 34,
//                Name = "Hyundai Sonata (2020)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0065c70e192baafbed5fd4118ff19cf1_SONATA.png",
//                Description = "Седан бизнес-класса",
//                Price = 68.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "98L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Роскошный интерьер",
//                    "Плавный ход"
//                }
//            },
//            new Car()
//            {
//                id = 35,
//                Name = "Hyundai Santa Fe (2022)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/1b5d5afe690d8fcced0b012c4a7fbd74_PALISADE.png",
//                Description = "Семейный кроссовер",
//                Price = 78.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "110L",
//                Capacity = "7 Person",
//                Comments = new[] {
//                    "Надежная конструкция",
//                    "Многофункциональный"
//                }
//            },
//            new Car()
//            {
//                id = 36,
//                Name = "Hyundai Elantra (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0f4c9df4f558109ad20248cf1a2ed07b_ELANTRA.png",
//                Description = "Современный седан",
//                Price = 62.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "96L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Стильный экстерьер",
//                    "Богатая комплектация"
//                }
//            },
//            new Car()
//            {
//                id = 37,
//                Name = "Hyundai Creta (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/73b717776f26594ad721ec152838c19d_creta2_conf.png",
//                Description = "Обновленный кроссовер",
//                Price = 67.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "97L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Популярная модель",
//                    "Хорошая проходимость"
//                }
//            },
//            new Car()
//            {
//                id = 38,
//                Name = "Hyundai Solaris (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0065c70e192baafbed5fd4118ff19cf1_SONATA.png",
//                Description = "Компактный седан",
//                Price = 58.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sedan,
//                Fuel = "92L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Городской автомобиль",
//                    "Экономичный"
//                }
//            },
//            new Car()
//            {
//                id = 39,
//                Name = "Hyundai Palisade (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/1b5d5afe690d8fcced0b012c4a7fbd74_PALISADE.png",
//                Description = "Флагманский внедорожник",
//                Price = 90.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "125L",
//                Capacity = "7 Person",
//                Comments = new[] {
//                    "Премиум-класс",
//                    "Все опции включены"
//                }
//            },
//            new Car()
//            {
//                id = 40,
//                Name = "Hyundai Staria (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/dde24f691dc7a5aa10acd4fb535ad82a_Staria.png",
//                Description = "Минивэн нового поколения",
//                Price = 80.00m,
//                Transmissions = "Automatic",
//                Type = CarType.MPV,
//                Fuel = "118L",
//                Capacity = "8 Person",
//                Comments = new[] {
//                    "Футуристичный дизайн",
//                    "Максимум пространства"
//                }
//            },
//            new Car()
//            {
//                id = 41,
//                Name = "Hyundai Tucson Hybrid (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/148c8e3342e8cef7bf71fcd1f2c19b2e_TUCSON.png",
//                Description = "Гибридный кроссовер",
//                Price = 82.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "Hybrid",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Экологичный",
//                    "Экономичный расход"
//                }
//            },
//            new Car()
//            {
//                id = 42,
//                Name = "Hyundai Sonata N-Line (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0065c70e192baafbed5fd4118ff19cf1_SONATA.png",
//                Description = "Спортивный седан",
//                Price = 75.00m,
//                Transmissions = "Automatic",
//                Type = CarType.Sport,
//                Fuel = "105L",
//                Capacity = "5 Person",
//                Comments = new[] {
//                    "Мощный двигатель",
//                    "Спортивный дизайн"
//                }
//            },
//            new Car()
//            {
//                id = 43,
//                Name = "Hyundai Santa Fe Hybrid (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/1b5d5afe690d8fcced0b012c4a7fbd74_PALISADE.png",
//                Description = "Гибридный внедорожник",
//                Price = 85.00m,
//                Transmissions = "Automatic",
//                Type = CarType.SUV,
//                Fuel = "Hybrid",
//                Capacity = "7 Person",
//                Comments = new[] {
//                    "Экологичный",
//                    "Просторный салон"
//                }
//            },
//            new Car()
//            {
//                id = 44,
//                Name = "Hyundai Elantra N (2023)",
//                image = "https://api.configurator.hyundai.ru/images/car_type/0f4c9df4f558109ad20248cf1a2ed07b_ELANTRA.png",
//                Description = "Гоночный седан",
//                Price = 78.00m,
//                Transmissions = "Manual",
//                Type = CarType.Sport,
//                Fuel = "110L",
//                Capacity = "4 Person",
//                Comments = new[] {
//                    "Спортивная подвеска",
//                    "Мощный двигатель"
//                }
//            }
//        };
//    }
//}