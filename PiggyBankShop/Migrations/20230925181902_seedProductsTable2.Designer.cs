﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PiggyBankShop.Data;

#nullable disable

namespace PiggyBankShop.Migrations
{
    [DbContext(typeof(PiggyBankShopDbContext))]
    [Migration("20230925181902_seedProductsTable2")]
    partial class seedProductsTable2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PiggyBankShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrendingProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Saul, Saul... this man that we spoke of before, this... this person that you said could... could disappear me, get me a whole new life and make sure that I'm never found. Yeah I need him, Saul. Gus is gonna murder my whole family. I need this man now. Saul... now, Saul!  ",
                            ImageUrl = "https://t3.ftcdn.net/jpg/00/61/45/26/360_F_61452654_zeYz36bPOmoRvlbya4ZfUebgQBHmnaXd.jpg",
                            IsTrendingProduct = true,
                            Name = "Big pig",
                            Price = 35m
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Anything suspicious? Well... then should we go? Any uh... Cartel news these days? Seems like I'm always reading something or other in the paper. I don't want to talk about it. To you or anyone else. I'm done explaining myself. Gus is dead. We've got work to do. ",
                            ImageUrl = "https://media.istockphoto.com/id/487095850/fr/photo/petite-fille-posant-pi%C3%A8ce-dans-la-tirelire-cochon.jpg?s=612x612&w=0&k=20&c=UA10ljeAtDh0w4AZdSkfmHVplnWxLKLBa7cq3bUUqMA=",
                            IsTrendingProduct = true,
                            Name = "Big pig 2",
                            Price = 35m
                        },
                        new
                        {
                            Id = 3,
                            Detail = "",
                            ImageUrl = "https://st2.depositphotos.com/1003345/5621/i/450/depositphotos_56215951-stock-photo-piggy-bank-with-graduation-hat.jpg",
                            IsTrendingProduct = true,
                            Name = "Middle pig",
                            Price = 25m
                        },
                        new
                        {
                            Id = 4,
                            Detail = "Jesse Jackson? Do you even... ah, I see you have a telephone at least. You know that blinking thing I've been calling you on? I will break this, I will BREAK THIS. Damn druggie idiot. Is this what you've been doing the whole time I've been trying to reach you? ",
                            ImageUrl = "https://static7.depositphotos.com/1026550/790/i/450/depositphotos_7900543-stock-photo-savings.jpg",
                            IsTrendingProduct = true,
                            Name = "Middle pig 2",
                            Price = 25m
                        },
                        new
                        {
                            Id = 5,
                            Detail = "The game has changed. The word is out. And you... are a killer. Apparently it's all over town. Somebody crossed you, you got angry, you crushed their skull with an ATM machine. Who cares! Just as long as it's our competitors who believe it and not the police. ",
                            ImageUrl = "https://static8.depositphotos.com/1064545/831/i/450/depositphotos_8316963-stock-photo-businessman-inserting-a-coin-in.jpg",
                            IsTrendingProduct = true,
                            Name = "Little pig",
                            Price = 15m
                        },
                        new
                        {
                            Id = 6,
                            Detail = "Plongez dans le monde de l'épargne tout en douceur avec notre tirelire \"Cochon-Peluche\" ! ",
                            ImageUrl = "https://st3.depositphotos.com/1010613/18043/i/450/depositphotos_180430118-stock-photo-close-stacked-coins-front-upside.jpg",
                            IsTrendingProduct = true,
                            Name = "Little pig 2",
                            Price = 15m
                        },
                        new
                        {
                            Id = 7,
                            Detail = "Préparez-vous à une révolution économique avec notre tirelire \"Porcinovation\" ! ",
                            ImageUrl = "https://st2.depositphotos.com/1010613/6961/i/450/depositphotos_69619103-stock-photo-piggy-bank-with-sunglasses.jpg",
                            IsTrendingProduct = true,
                            Name = "Little pig 3",
                            Price = 15m
                        },
                        new
                        {
                            Id = 8,
                            Detail = "Si vous êtes un amoureux des chats et de l'argent, notre tirelire \"Chat-pitalisme\" est faite pour vous ! Cette tirelire en forme de chat astucieux vous encourage à économiser tout en gardant un œil sur vos finances. Non seulement elle garde jalousement vos économies, mais elle peut aussi miauler quand vous atteignez un objectif d'épargne ! C'est la seule tirelire qui vous encourage à économiser tout en vous lançant des regards suspicieux lorsque vous dépensez trop. Devenez un véritable \"chat-pitaliste\" avec style !\r\n\r\nN'oubliez pas, ces tirelires ajoutent une touche d'humour à votre épargne, rendant le processus d'économie encore plus amusant !",
                            ImageUrl = "https://tirelire-peggybank.com/cdn/shop/products/tirelire-kawaii-chat_c815fb34-1922-4b96-a5ca-2cd9ddcd2fd2_480x480.jpg?v=1641984305",
                            IsTrendingProduct = true,
                            Name = "Chat-pitalisme",
                            Price = 15m
                        },
                        new
                        {
                            Id = 9,
                            Detail = "Plongez dans le monde de l'épargne avec notre tirelire \"Coin-Coin\" ! Cette tirelire en forme de canard vous fera quitter le quai de l'achat compulsif pour vous embarquer sur la rivière de l'économie. Chaque pièce que vous glissez dans cette tirelire fait un \"coin-coin\" mignon, vous rappelant que chaque centime compte. Et si vous la secouez, elle secouera même la queue de joie ! La tirelire \"Coin-Coin\" transforme l'économie en une aventure en caoutchouc palpitante.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzOOyjbDK7OFXVvwRP64gz9kPN4QQSJWS4tw&usqp=CAU",
                            IsTrendingProduct = true,
                            Name = "Coin-coin",
                            Price = 15m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}