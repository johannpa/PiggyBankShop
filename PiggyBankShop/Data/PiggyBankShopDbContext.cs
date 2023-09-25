using Microsoft.EntityFrameworkCore;
using PiggyBankShop.Models;

namespace PiggyBankShop.Data
{
    public class PiggyBankShopDbContext : DbContext
    {
        public PiggyBankShopDbContext(DbContextOptions<PiggyBankShopDbContext> options):base(options)
        {
        }
        public DbSet<Product> Products{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                
                new Product { Id = 1, Name = "Big pig", Detail = "Saul, Saul... this man that we spoke of before, this... this person that you said could... could disappear me, get me a whole new life and make sure that I'm never found. Yeah I need him, Saul. Gus is gonna murder my whole family. I need this man now. Saul... now, Saul!  ", Price = 35, IsTrendingProduct = true, ImageUrl = "https://t3.ftcdn.net/jpg/00/61/45/26/360_F_61452654_zeYz36bPOmoRvlbya4ZfUebgQBHmnaXd.jpg" },
                new Product { Id = 2, Name = "Big pig 2", Detail = "Anything suspicious? Well... then should we go? Any uh... Cartel news these days? Seems like I'm always reading something or other in the paper. I don't want to talk about it. To you or anyone else. I'm done explaining myself. Gus is dead. We've got work to do. ", Price = 35, IsTrendingProduct = true, ImageUrl = "https://media.istockphoto.com/id/487095850/fr/photo/petite-fille-posant-pi%C3%A8ce-dans-la-tirelire-cochon.jpg?s=612x612&w=0&k=20&c=UA10ljeAtDh0w4AZdSkfmHVplnWxLKLBa7cq3bUUqMA=" },
                new Product { Id = 3, Name = "Middle pig", Detail = "", Price = 25, IsTrendingProduct = true, ImageUrl = "https://st2.depositphotos.com/1003345/5621/i/450/depositphotos_56215951-stock-photo-piggy-bank-with-graduation-hat.jpg" },
                new Product { Id = 4, Name = "Middle pig 2", Detail = "Jesse Jackson? Do you even... ah, I see you have a telephone at least. You know that blinking thing I've been calling you on? I will break this, I will BREAK THIS. Damn druggie idiot. Is this what you've been doing the whole time I've been trying to reach you? ", Price = 25, IsTrendingProduct = true, ImageUrl = "https://static7.depositphotos.com/1026550/790/i/450/depositphotos_7900543-stock-photo-savings.jpg" },
                new Product { Id = 5, Name = "Little pig", Detail = "The game has changed. The word is out. And you... are a killer. Apparently it's all over town. Somebody crossed you, you got angry, you crushed their skull with an ATM machine. Who cares! Just as long as it's our competitors who believe it and not the police. ", Price = 15, IsTrendingProduct = true, ImageUrl = "https://static8.depositphotos.com/1064545/831/i/450/depositphotos_8316963-stock-photo-businessman-inserting-a-coin-in.jpg" },
                new Product { Id = 6, Name = "Little pig 2", Detail = "Plongez dans le monde de l'épargne tout en douceur avec notre tirelire \"Cochon-Peluche\" ! ", Price = 15, IsTrendingProduct = true, ImageUrl = "https://st3.depositphotos.com/1010613/18043/i/450/depositphotos_180430118-stock-photo-close-stacked-coins-front-upside.jpg" },
                new Product { Id = 7, Name = "Little pig 3", Detail = "Préparez-vous à une révolution économique avec notre tirelire \"Porcinovation\" ! ", Price = 15, IsTrendingProduct = true, ImageUrl = "https://st2.depositphotos.com/1010613/6961/i/450/depositphotos_69619103-stock-photo-piggy-bank-with-sunglasses.jpg" },
                new Product { Id = 8, Name = "Chat-pitalisme", Detail = "Si vous êtes un amoureux des chats et de l'argent, notre tirelire \"Chat-pitalisme\" est faite pour vous ! Cette tirelire en forme de chat astucieux vous encourage à économiser tout en gardant un œil sur vos finances. Non seulement elle garde jalousement vos économies, mais elle peut aussi miauler quand vous atteignez un objectif d'épargne ! C'est la seule tirelire qui vous encourage à économiser tout en vous lançant des regards suspicieux lorsque vous dépensez trop. Devenez un véritable \"chat-pitaliste\" avec style !\r\n\r\nN'oubliez pas, ces tirelires ajoutent une touche d'humour à votre épargne, rendant le processus d'économie encore plus amusant !", Price = 15, IsTrendingProduct = true, ImageUrl = "https://tirelire-peggybank.com/cdn/shop/products/tirelire-kawaii-chat_c815fb34-1922-4b96-a5ca-2cd9ddcd2fd2_480x480.jpg?v=1641984305" },
                new Product { Id = 9, Name = "Coin-coin", Detail = "Plongez dans le monde de l'épargne avec notre tirelire \"Coin-Coin\" ! Cette tirelire en forme de canard vous fera quitter le quai de l'achat compulsif pour vous embarquer sur la rivière de l'économie. Chaque pièce que vous glissez dans cette tirelire fait un \"coin-coin\" mignon, vous rappelant que chaque centime compte. Et si vous la secouez, elle secouera même la queue de joie ! La tirelire \"Coin-Coin\" transforme l'économie en une aventure en caoutchouc palpitante.", Price = 15, IsTrendingProduct = true, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzOOyjbDK7OFXVvwRP64gz9kPN4QQSJWS4tw&usqp=CAU" }







                );
        }
    }
}
