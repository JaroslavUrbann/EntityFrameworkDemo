using System;
using EFDemo.DL.Repositories;

namespace EFDemo.DL
{
	internal interface IUnitOfWork : IDisposable
	{
		ISongRepository Songs { get; }
		int Save();
	}
}