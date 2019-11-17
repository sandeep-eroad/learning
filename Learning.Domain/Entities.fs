namespace Learning.Domain.Entities

open System

module Persons =
    type Person =
        {
            Id: Guid
            Name: String
            Phones: List<Guid>
        }

module Phones =
    type Phone =
        {
            Id: Guid
            Number: String
        }
