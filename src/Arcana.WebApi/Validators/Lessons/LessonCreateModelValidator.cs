﻿using FluentValidation;
using Arcana.WebApi.Models.Lessons;

namespace Arcana.WebApi.Validators.Lessons;

public class LessonCreateModelValidator : AbstractValidator<LessonCreateModel>
{
    public LessonCreateModelValidator()
    {
        RuleFor(lesson => lesson.Title)
            .NotNull()
            .WithMessage(lesson => $"{nameof(lesson.Title)} is not specified");

        RuleFor(lesson => lesson.ModuleId)
            .NotNull()
            .WithMessage(lesson => $"{nameof(lesson.ModuleId)} is not specified");

        RuleFor(lesson => lesson.File.File)
            .NotNull()
            .WithMessage(lesson => $"{nameof(lesson.ModuleId)} is not specified");

        RuleFor(lesson => lesson.File.FileType)
            .NotNull()
            .IsInEnum()
            .WithMessage(lesson => $"{nameof(lesson.File.FileType)} is not specified");
    }
}