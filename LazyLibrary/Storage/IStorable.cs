﻿using System;

namespace LazyLibrary.Storage
{
    public interface IStorable<T> : IEquatable<T>
    {
        int Id { get; set; }
    }
}