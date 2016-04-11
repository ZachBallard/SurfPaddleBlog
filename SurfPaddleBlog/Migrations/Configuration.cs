namespace SurfPaddleBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SurfPaddleBlog.Models.SurfPaddleBlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SurfPaddleBlog.Models.SurfPaddleBlogContext";
        }

        protected override void Seed(SurfPaddleBlog.Models.SurfPaddleBlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Blogs.AddOrUpdate(
                b => b.Title,
                new Models.Blog
                {
                    Title = "I am a seed post!",
                    Author = "Amy Duperson",
                    AuthorPictureUrl = "https://headshotcrew.com/sites/default/files/styles/square-large/public/unknown-f.jpg?itok=ETYTyWCI",
                    PostTime = new DateTime(2016, 02, 01),
                    Body1 = "Venmo ennui hashtag biodiesel portland. Yr meditation dreamcatcher, synth fanny pack listicle etsy craft beer leggings single-origin coffee offal four dollar toast. Listicle single-origin coffee occupy irony. VHS everyday carry mixtape tote bag truffaut, 8-bit quinoa migas before they sold out freegan kogi. Drinking vinegar PBR&B chillwave raw denim. Lumbersexual taxidermy humblebrag scenester.",
                    Body2 = "XOXO tousled pickled austin. PBR&B fap slow-carb aesthetic etsy ugh, pour-over bespoke twee kale chips. Mlkshk gentrify raw denim viral. Sartorial tofu bespoke, ugh crucifix retro tumblr taxidermy next level tote bag seitan. Locavore tilde bicycle rights blog pabst post-ironic readymade, direct trade photo booth tacos trust fund.",
                    BigMiddleText = "HIPSTER IPSUM!",
                    SideBarTitle = "Blah blah blah?",
                    SideBarBody = "Disrupt shabby chic slow-carb sustainable, listicle stumptown pug truffaut. Hoodie distillery vice, bicycle rights 3 wolf moon pop-up beard poutine kickstarter chicharrones. Tattooed single-origin coffee tote bag.",
                    AdPictureUrl = "https://longawkwardpause.files.wordpress.com/2016/01/bye-bye-hipster.jpg"
                },
                new Models.Blog
                {
                    Title = "Your Mom!",
                    Author = "Your Mom",
                    AuthorPictureUrl = "https://headshotcrew.com/sites/default/files/styles/square-large/public/unknown-f.jpg?itok=ETYTyWCI",
                    PostTime = new DateTime(2016, 01, 01),
                    Body1 = "Venmo ennui hashtag biodiesel portland. Yr meditation dreamcatcher, synth fanny pack listicle etsy craft beer leggings single-origin coffee offal four dollar toast. Listicle single-origin coffee occupy irony. VHS everyday carry mixtape tote bag truffaut, 8-bit quinoa migas before they sold out freegan kogi. Drinking vinegar PBR&B chillwave raw denim. Lumbersexual taxidermy humblebrag scenester.",
                    Body2 = "XOXO tousled pickled austin. PBR&B fap slow-carb aesthetic etsy ugh, pour-over bespoke twee kale chips. Mlkshk gentrify raw denim viral. Sartorial tofu bespoke, ugh crucifix retro tumblr taxidermy next level tote bag seitan. Locavore tilde bicycle rights blog pabst post-ironic readymade, direct trade photo booth tacos trust fund.",
                    BigMiddleText = "HIPSTER IPSUM!",
                    SideBarTitle = "Blah blah blah?",
                    SideBarBody = "Disrupt shabby chic slow-carb sustainable, listicle stumptown pug truffaut. Hoodie distillery vice, bicycle rights 3 wolf moon pop-up beard poutine kickstarter chicharrones. Tattooed single-origin coffee tote bag.",
                    AdPictureUrl = "https://pbs.twimg.com/profile_images/2489824976/wrnw3y2lvmxv14rd8zvr_400x400.jpeg"
                }
                );
        }
    }
}
