using Ninject;
using Tinder.Api.Infrastructure.Application;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Infrastructure.Domain.Factories;
using Tinder.Api.Infrastructure.Domain.Factories.Interfaces;
using Tinder.Api.Infrastructure.Repository;
using Tinder.Api.Infrastructure.Repository.Interfaces;
using Tinder.Api.Mappers;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Configuration
{
    public sealed class Ninject
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IDiscoveryMapper>().To<DiscoveryMapper>().InSingletonScope();
            kernel.Bind<IMatchMapper>().To<MatchMapper>().InSingletonScope();
            kernel.Bind<IMessageMapper>().To<MessageMapper>().InSingletonScope();
            kernel.Bind<IPhotoMapper>().To<PhotoMapper>().InSingletonScope();
            kernel.Bind<IDiscoverySettingsMapper>().To<DiscoverySettingsMapper>().InSingletonScope();
            kernel.Bind<IUserMapper>().To<UserMapper>().InSingletonScope();
            kernel.Bind<IFriendMapper>().To<FriendMapper>().InSingletonScope();
            kernel.Bind<IInterestMapper>().To<InterestMapper>().InSingletonScope();
            kernel.Bind<IUsersApplication>().To<UsersApplication>().InSingletonScope();
            kernel.Bind<IDiscoveriesApplication>().To<DiscoveriesApplication>().InSingletonScope();
            kernel.Bind<IMatchesApplication>().To<MatchesApplication>().InSingletonScope();
            kernel.Bind<IDiscoverySettingsApplication>().To<DiscoverySettingsApplication>().InSingletonScope();
            kernel.Bind<IUsersRepository>().To<UsersRepository>().InSingletonScope();
            kernel.Bind<IDiscoveriesRepository>().To<DiscoveriesRepository>().InSingletonScope();
            kernel.Bind<IMatchesRepository>().To<MatchesRepository>().InSingletonScope();
            kernel.Bind<IDiscoverySettingsRepository>().To<DiscoverySettingsRepository>().InSingletonScope();
            kernel.Bind<IModelFactory>().To<ModelFactory>().InSingletonScope();

            return kernel;
        }
    }
}