﻿using System;
namespace Lab3
{
    public enum InvalidFieldError
    {
        InvalidClueLength,
        InvalidAnswerLength,
        InvalidDifficulty,
        InvalidDate,
        NoError
    }

    public enum EntryDeletionError
    {
        EntryNotFound,
        DBDeletionError,
        NoError
    }

    public enum EntryEditError
    {
        EntryNotFound,
        InvalidFieldError,
        DBEditError,
        NoError
    }
}

