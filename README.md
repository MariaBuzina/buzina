# Бузина Мария Алексеевна ИС-21А
![Изображение](https://www.aqualogo.ru/u_luagushka_2.jpg "Бузина Мария")
## АИС Мебельный салон
*АИС Мебельный салон* разработана для **отслеживания** товара на складе и его поступления. 
### Функционал
~~Приложение готово к использованию!~~
 string[] captchaFile;
            captchaFile = Directory.GetFiles(@".\Resources\", "*.png");

            Random random = new Random();
            int index = random.Next(captchaFile.Length);
            pictureBox1.Image = Image.FromFile(captchaFile[index]);

private bool isTextVisible = false;
{
isTextVisible = !isTextVisible;

            if (isTextVisible)
            {
                textBox2.PasswordChar = default;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
}
