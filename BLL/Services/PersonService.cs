using System;
using System.Collections.Generic;
using BLL.Models;

namespace BLL.Services
{
    public static class PersonService
    {
        /// <summary>
        /// Get all Persons from data collection(base)
        /// </summary>
        /// <returns>List of Person instances</returns>
        public static List<Person> GetPersons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Person by Id
        /// </summary>
        /// <param name="personId">Id of person</param>
        /// <returns>Person instance</returns>
        public static Person GetPersonById(int personId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a person's contacts
        /// </summary>
        /// <param name="personId">Id of person</param>
        /// <returns>List of person's contacts</returns>
        public static List<Contact> GetPersonContacts(int personId)
        {
            return GetPersonContacts(GetPersonById(personId));
        }

        /// <summary>
        /// Get a person's contacts
        /// </summary>
        /// <param name="person">Person instance</param>
        /// <returns>List of person's contacts</returns>
        public static List<Contact> GetPersonContacts(Person person)
        {
            throw new NotImplementedException();
        }  
    }
}