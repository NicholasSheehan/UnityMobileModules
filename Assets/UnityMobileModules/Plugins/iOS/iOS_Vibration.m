#import <Foundation/Foundation.h>

UISelectionFeedbackGenerator* SelectionFeedbackGenerator; //Selection
UINotificationFeedbackGenerator* NotificationFeedbackGenerator; //Success, Warining, Failure

UIImpactFeedbackGenerator* LightImpactFeedbackGenerator;
UIImpactFeedbackGenerator* MediumImpactFeedbackGenerator;
UIImpactFeedbackGenerator* HeavyImpactFeedbackGenerator;

void iOS_Selection()
{
	if(SelectionFeedbackGenerator == nil) SelectionFeedbackGenerator = [[UISelectionFeedbackGenerator alloc] init];
    [SelectionFeedbackGenerator prepare];
    [SelectionFeedbackGenerator selectionChanged];
}

void iOS_Success()
{
	if(NotificationFeedbackGenerator == nil)	NotificationFeedbackGenerator = [[UINotificationFeedbackGenerator alloc] init];		
    [NotificationFeedbackGenerator prepare];
    [NotificationFeedbackGenerator notificationOccurred:UINotificationFeedbackTypeSuccess];
}

void iOS_Warning()
{
    if(NotificationFeedbackGenerator == nil)	NotificationFeedbackGenerator = [[UINotificationFeedbackGenerator alloc] init];		
    [NotificationFeedbackGenerator prepare];
    [NotificationFeedbackGenerator notificationOccurred:UINotificationFeedbackTypeWarning];
}

void iOS_Failure()
{
	if(NotificationFeedbackGenerator == nil)	NotificationFeedbackGenerator = [[UINotificationFeedbackGenerator alloc] init];		
    [NotificationFeedbackGenerator prepare];
    [NotificationFeedbackGenerator notificationOccurred:UINotificationFeedbackTypeError];
}

void iOS_LightImpact()
{
    if(LightImpactFeedbackGenerator == nil) LightImpactFeedbackGenerator = [[UIImpactFeedbackGenerator alloc] initWithStyle:UIImpactFeedbackStyleLight];
    [LightImpactFeedbackGenerator prepare];
    [LightImpactFeedbackGenerator impactOccurred];
}

void iOS_MediumImpact()
{
	if(MediumImpactFeedbackGenerator == nil) MediumImpactFeedbackGenerator = [[UIImpactFeedbackGenerator alloc] initWithStyle:UIImpactFeedbackStyleMedium];
    [MediumImpactFeedbackGenerator prepare];
    [MediumImpactFeedbackGenerator impactOccurred];
}

void iOS_HeavyImpact()
{
	if(HeavyImpactFeedbackGenerator == nil) HeavyImpactFeedbackGenerator = [[UIImpactFeedbackGenerator alloc] initWithStyle:UIImpactFeedbackStyleHeavy];
    [HeavyImpactFeedbackGenerator prepare];
    [HeavyImpactFeedbackGenerator impactOccurred];
}
