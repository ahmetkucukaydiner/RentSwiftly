﻿using Microsoft.EntityFrameworkCore;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Persistence.Context;

public class RentSwiftlyContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; initial catalog=RentSwiftly; integrated security=true;");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Reservation>()
			.HasOne(x => x.PickUpLocation)
			.WithMany(y => y.PickUpReservation)
			.HasForeignKey(z => z.PickUpLocationID)
			.OnDelete(DeleteBehavior.ClientSetNull);

		modelBuilder.Entity<Reservation>()
			.HasOne(x => x.DropOffLocation)
			.WithMany(y => y.DropOffReservation)
			.HasForeignKey(z => z.DropOffLocationID)
			.OnDelete(DeleteBehavior.ClientSetNull);
	}

	public DbSet<About> Abouts { get; set; }
	public DbSet<Banner> Banners { get; set; }
	public DbSet<Brand> Brands { get; set; }
	public DbSet<Car> Cars { get; set; }
	public DbSet<CarDescription> CarDescriptions { get; set; }
	public DbSet<CarFeature> CarFeatures { get; set; }
	public DbSet<CarPricing> CarPricings { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<Contact> Contacts { get; set; }
	public DbSet<Feature> Features { get; set; }
	public DbSet<FooterAddress> FooterAddresses { get; set; }
	public DbSet<Location> Locations { get; set; }
	public DbSet<Pricing> Pricings { get; set; }
	public DbSet<Service> Services { get; set; }
	public DbSet<SocialMedia> SocialMedias { get; set; }
	public DbSet<Testimonial> Testimonials { get; set; }
	public DbSet<Author> Authors { get; set; }
	public DbSet<Blog> Blogs { get; set; }
	public DbSet<TagCloud> TagClouds { get; set; }
	public DbSet<Comment> Comments { get; set; }
	public DbSet<RentACar> RentACars { get; set; }
	public DbSet<Reservation> Reservations { get; set; }
	public DbSet<Review> Reviews { get; set; }
}