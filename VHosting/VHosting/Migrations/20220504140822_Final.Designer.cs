// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VHosting;

#nullable disable

namespace VHosting.Migrations
{
    [DbContext(typeof(DBVideoHostingContext))]
    [Migration("20220504140822_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PlaylistVideo", b =>
                {
                    b.Property<int>("PlaylistId")
                        .HasColumnType("int")
                        .HasColumnName("playlist_id");

                    b.Property<int>("VideoId")
                        .HasColumnType("int")
                        .HasColumnName("video_id");

                    b.HasKey("PlaylistId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("playlist_video", (string)null);
                });

            modelBuilder.Entity("SubscriberUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("SubsriberId")
                        .HasColumnType("int")
                        .HasColumnName("subsriber_id");

                    b.HasKey("UserId", "SubsriberId")
                        .HasName("PK_subscriber_user_1");

                    b.HasIndex("SubsriberId");

                    b.ToTable("subscriber_user", (string)null);
                });

            modelBuilder.Entity("UserPlaylist", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int")
                        .HasColumnName("playlist_id");

                    b.HasKey("UserId", "PlaylistId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("user_playlist", (string)null);
                });

            modelBuilder.Entity("VHosting.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Permissions")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("permissions");

                    b.HasKey("Id");

                    b.ToTable("account", (string)null);
                });

            modelBuilder.Entity("VHosting.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("VideoId")
                        .HasColumnType("int")
                        .HasColumnName("video_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VideoId");

                    b.ToTable("comment", (string)null);
                });

            modelBuilder.Entity("VHosting.PaymentReceipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ReceiptLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("receipt_link");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("int")
                        .HasColumnName("subscription_type");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("payment_receipt", (string)null);
                });

            modelBuilder.Entity("VHosting.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("CreatedAt")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("playlist", (string)null);
                });

            modelBuilder.Entity("VHosting.SettingsOption", b =>
                {
                    b.Property<int>("SettingsId")
                        .HasColumnType("int")
                        .HasColumnName("settings_id");

                    b.Property<int>("OptionId")
                        .HasColumnType("int")
                        .HasColumnName("option_id");

                    b.Property<string>("Value")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("value");

                    b.HasKey("SettingsId", "OptionId");

                    b.ToTable("settings_option", (string)null);
                });

            modelBuilder.Entity("VHosting.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int")
                        .HasColumnName("account_type");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit")
                        .HasColumnName("is_verified");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nickname");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentCard")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("payment_card");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AccountType");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex(new[] { "Email" }, "UK_email")
                        .IsUnique();

                    b.HasIndex(new[] { "Nickname" }, "UK_nickname")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("VHosting.UserSetting", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("SettingsId")
                        .HasColumnType("int")
                        .HasColumnName("settings_id");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "SettingsId" }, "UN_settings")
                        .IsUnique();

                    b.ToTable("user_settings", (string)null);
                });

            modelBuilder.Entity("VHosting.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int")
                        .HasColumnName("dislikes");

                    b.Property<bool>("IsMonetized")
                        .HasColumnType("bit")
                        .HasColumnName("is_monetized");

                    b.Property<int>("Likes")
                        .HasColumnType("int")
                        .HasColumnName("likes");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("link");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("video", (string)null);
                });

            modelBuilder.Entity("VHosting.WatchedVideo", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("VideoId")
                        .HasColumnType("int")
                        .HasColumnName("video_id");

                    b.Property<bool>("IsDisliked")
                        .HasColumnType("bit")
                        .HasColumnName("is_disliked");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("bit")
                        .HasColumnName("is_liked");

                    b.Property<TimeSpan>("WatchedTime")
                        .HasColumnType("time")
                        .HasColumnName("watched_time");

                    b.HasKey("UserId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("watched_video", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaylistVideo", b =>
                {
                    b.HasOne("VHosting.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .IsRequired()
                        .HasConstraintName("FK_playlist_video_playlist");

                    b.HasOne("VHosting.Video", null)
                        .WithMany()
                        .HasForeignKey("VideoId")
                        .IsRequired()
                        .HasConstraintName("FK_playlist_video_video");
                });

            modelBuilder.Entity("SubscriberUser", b =>
                {
                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("SubsriberId")
                        .IsRequired()
                        .HasConstraintName("FK_subscriber_user_user1");

                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_subscriber_user_user");
                });

            modelBuilder.Entity("UserPlaylist", b =>
                {
                    b.HasOne("VHosting.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .IsRequired()
                        .HasConstraintName("FK_user_playlist_playlist");

                    b.HasOne("VHosting.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_user_playlist_user");
                });

            modelBuilder.Entity("VHosting.Comment", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_comment_user");

                    b.HasOne("VHosting.Video", "Video")
                        .WithMany("Comments")
                        .HasForeignKey("VideoId")
                        .IsRequired()
                        .HasConstraintName("FK_comment_video");

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("VHosting.PaymentReceipt", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithMany("PaymentReceipts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_payment_receipt_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VHosting.Playlist", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_playlist_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VHosting.SettingsOption", b =>
                {
                    b.HasOne("VHosting.UserSetting", "Settings")
                        .WithMany("SettingsOptions")
                        .HasForeignKey("SettingsId")
                        .HasPrincipalKey("SettingsId")
                        .IsRequired()
                        .HasConstraintName("FK_settings_option_user_settings");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("VHosting.User", b =>
                {
                    b.HasOne("VHosting.Account", "AccountTypeNavigation")
                        .WithMany("Users")
                        .HasForeignKey("AccountType")
                        .IsRequired()
                        .HasConstraintName("FK_user_account");

                    b.Navigation("AccountTypeNavigation");
                });

            modelBuilder.Entity("VHosting.UserSetting", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithOne("UserSetting")
                        .HasForeignKey("VHosting.UserSetting", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_user_settings_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VHosting.Video", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithMany("Videos")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_video_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VHosting.WatchedVideo", b =>
                {
                    b.HasOne("VHosting.User", "User")
                        .WithMany("WatchedVideos")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_watched_video_user");

                    b.HasOne("VHosting.Video", "Video")
                        .WithMany("WatchedVideos")
                        .HasForeignKey("VideoId")
                        .IsRequired()
                        .HasConstraintName("FK_watched_video_video");

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("VHosting.Account", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("VHosting.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PaymentReceipts");

                    b.Navigation("Playlists");

                    b.Navigation("UserSetting")
                        .IsRequired();

                    b.Navigation("Videos");

                    b.Navigation("WatchedVideos");
                });

            modelBuilder.Entity("VHosting.UserSetting", b =>
                {
                    b.Navigation("SettingsOptions");
                });

            modelBuilder.Entity("VHosting.Video", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("WatchedVideos");
                });
#pragma warning restore 612, 618
        }
    }
}
