using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using Domain.Models;

namespace DAL
{
    public class DbInit : DropCreateDatabaseIfModelChanges<CurriculumVitaeDbContext>
    {
        protected override void Seed(CurriculumVitaeDbContext context)
        {

            ContactTypeSeed(context);
            EducationTypeSeed(context);
            ExperienceTypeSeed(context);
            SkillTypeSeed(context);
            MyAwesomeCvSeed(context);

            base.Seed(context);
        }

        private void ContactTypeSeed(CurriculumVitaeDbContext ctx)
        {
            ctx.ContactTypes.Add(new ContactType() { ContactTypeName = "Telefon" });
            ctx.ContactTypes.Add(new ContactType() { ContactTypeName = "E-mail" });
            ctx.ContactTypes.Add(new ContactType() { ContactTypeName = "Skype" });

            ctx.SaveChanges();
        }

        private void EducationTypeSeed(CurriculumVitaeDbContext ctx)
        {
            ctx.EducationTypes.Add(new EducationType() { EducationTypeName = "Põhiharidus" });
            ctx.EducationTypes.Add(new EducationType() { EducationTypeName = "Keskharidus" });
            ctx.EducationTypes.Add(new EducationType() { EducationTypeName = "Kõrgharidus" });

            ctx.SaveChanges();
        }

        private void ExperienceTypeSeed(CurriculumVitaeDbContext ctx)
        {
            ctx.ExperienceTypes.Add(new ExperienceType() { ExperienceTypeName = "Töökoht" });

            ctx.SaveChanges();
        }

        private void SkillTypeSeed(CurriculumVitaeDbContext ctx)
        {
            ctx.SkillTypes.Add(new SkillType() { SkillTypeName = "Keeleoskus" });
            ctx.SkillTypes.Add(new SkillType() { SkillTypeName = "Sõiduoskus" });
            ctx.SkillTypes.Add(new SkillType() { SkillTypeName = "Arvutioskus" });

            ctx.SaveChanges();
        }

        private void MyAwesomeCvSeed(CurriculumVitaeDbContext ctx)
        {
            var telefonId = ctx.ContactTypes.FirstOrDefault(x => x.ContactTypeName == "Telefon")?.ContactTypeId ?? 0;
            var emailId = ctx.ContactTypes.FirstOrDefault(x => x.ContactTypeName == "E-mail")?.ContactTypeId ?? 0;
            var skypeId = ctx.ContactTypes.FirstOrDefault(x => x.ContactTypeName == "Skype")?.ContactTypeId ?? 0;

            var pohiharidusId = ctx.EducationTypes.FirstOrDefault(x => x.EducationTypeName == "Põhiharidus")?.EducationTypeId ?? 0;
            var keskharidusId = ctx.EducationTypes.FirstOrDefault(x => x.EducationTypeName == "Keskharidus")?.EducationTypeId ?? 0;
            var korgharidusId = ctx.EducationTypes.FirstOrDefault(x => x.EducationTypeName == "Kõrgharidus")?.EducationTypeId ?? 0;

            var tooId = ctx.ExperienceTypes.FirstOrDefault(x => x.ExperienceTypeName == "Töökoht")?.ExperienceTypeId ?? 0;

            var keeleId = ctx.SkillTypes.FirstOrDefault(x => x.SkillTypeName == "Keeleoskus")?.SkillTypeId ?? 0;
            var soiduId = ctx.SkillTypes.FirstOrDefault(x => x.SkillTypeName == "Sõiduoskus")?.SkillTypeId ?? 0;
            var arvutiId = ctx.SkillTypes.FirstOrDefault(x => x.SkillTypeName == "Arvutioskus")?.SkillTypeId ?? 0;

            ctx.Persons.Add(new Person()
            {
                Firstname = "Marko",
                Lastname = "Koiduste",
                Sex = Sex.Male,
                BirthDate = new DateTime(1994, 3, 8),
                Contacts = new ObservableCollection<Contact>()
                {
                    new Contact() {ContactValue = "59049636", ContactTypeId = telefonId},
                    new Contact() {ContactValue = "mkoiduste@gmail.com", ContactTypeId = emailId},
                    new Contact() {ContactValue = "marko.koiduste", ContactTypeId = skypeId}
                },
                Educations = new ObservableCollection<Education>()
                {
                    new Education() {EducationValue = "Kiili Gümnaasium", EducationTypeId = pohiharidusId, FromDate = new DateTime(2001, 9, 1), ToDate = new DateTime(2010, 6, 22)},
                    new Education() {EducationValue = "Nõo Reaalgümnaasium", EducationTypeId = keskharidusId, FromDate = new DateTime(2010, 9, 1), ToDate = new DateTime(2013, 6, 22)},
                    new Education() {EducationValue = "Tallinna Tehnikaülikool, Mehhatroonika eriala", EducationTypeId = korgharidusId, FromDate = new DateTime(2013, 9, 1), ToDate = new DateTime(2014, 5, 30)},
                    new Education() {EducationValue = "Eesti Infotehnoloogia Kolledž, Arenduse eriala", EducationTypeId = korgharidusId, FromDate = new DateTime(2014, 9, 1), ToDate = null}
                },
                Experiences = new ObservableCollection<Experience>()
                {
                    new Experience() {ExperienceValue = "Klienditeenindaja", Institute = "Statoil", ExperienceTypeId = tooId, FromDate = new DateTime(2014, 3, 1), ToDate = new DateTime(2014, 10, 16)},
                    new Experience() {ExperienceValue = "Monitoorija / Helpdesk operaator", Institute = "Danske Bank", ExperienceTypeId = tooId, FromDate = new DateTime(2014, 10, 17), ToDate = null}
                },
                Skills = new ObservableCollection<Skill>()
                {
                    new Skill() {SkillValue = "Inglise keel", SkillRating = "Väga hea", SkillTypeId = keeleId},
                    new Skill() {SkillValue = "Sõiduoskus", SkillRating = "A1, B", SkillTypeId = soiduId},
                    new Skill() {SkillValue = "C#", SkillRating = "Keskmine", SkillTypeId = arvutiId},
                    new Skill() {SkillValue = "Java", SkillRating = "Keskmine", SkillTypeId = arvutiId},
                    new Skill() {SkillValue = "C", SkillRating = "Rahuldav", SkillTypeId = arvutiId},
                    new Skill() {SkillValue = "SQL", SkillRating = "Rahuldav", SkillTypeId = arvutiId}
                }
            });

            ctx.SaveChanges();
        }
    }
}