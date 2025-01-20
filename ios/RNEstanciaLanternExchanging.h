#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNEstanciaLanternExchanging : UIResponder

+ (instancetype)shared;
- (void)estanciaLantern_el_configJanServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
