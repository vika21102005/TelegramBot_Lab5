// top-level statements (.NET 6)
using TelegramSimpleBot;
using System.Threading;

var token = Environment.GetEnvironmentVariable("TELEGRAM_TOKEN")
            ?? "7840274605:AAEkAI1yxygZp8n6Em7u8xTGgK9RiMXbGgc";

var bot = new BotService(token);

// коректне переривання Ctrl+C
using var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, e) => { e.Cancel = true; cts.Cancel(); };

Console.WriteLine("▶️  Bot is starting. Press Ctrl+C to stop.");
await bot.RunAsync(cts.Token);
