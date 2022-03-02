﻿using FluentValidation;
using Models.Pereval;

namespace Validators
{
	public class AddPerevalRequestValidator : AbstractValidator<AddPerevalRequest>
	{
		public AddPerevalRequestValidator()
		{
			RuleFor(x => x.title).NotEmpty();
			RuleFor(x => x.user.email).NotEmpty();
			RuleFor(x => x.coords).NotEmpty();

		}
	}
}
