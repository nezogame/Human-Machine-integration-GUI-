package MyPackage;

import javax.swing.*;

public class Controller {
    private static User currentUser;
    private static SignUp signUpFrame;
    private static Login loginFrame;
    private static MainWindow mainWindow;
    private static TrainingSignUp trainingSignUp;
    private static ImageIcon appIcon = new ImageIcon("src/main/resources/image/red_logo.png");


    public Controller() {
        signUpFrame = new SignUp();
        signUpFrame.setIconImage(appIcon.getImage());

        loginFrame = new Login();
        loginFrame.setIconImage(appIcon.getImage());

        mainWindow = new MainWindow();
        mainWindow.setIconImage(appIcon.getImage());

        trainingSignUp = new TrainingSignUp();
        trainingSignUp.setIconImage(appIcon.getImage());
    }

    public static void changeWindow (JFrame source,JFrame newWindow ) {
        newWindow.setVisible(true);
        source.setVisible(false);
    }

    public static void showTrainingSignUp(String training,boolean myConcept) {
        String updatedText = "You have chosen "+training ;
        trainingSignUp.setChosenTArea(updatedText);
        trainingSignUp.setVisible(true);
        if(myConcept) {
            trainingSignUp.coachTrainings(currentUser);
        }
        trainingSignUp.showMyConcept(myConcept);
    }


    public static SignUp getSignUpFrame() {
        return signUpFrame;
    }

    public void setSignUpFrame(SignUp signUpFrame) {
        this.signUpFrame = signUpFrame;
    }

    public static Login getLoginFrame() {
        return loginFrame;
    }

    public void setLoginFrame(Login loginFrame) {
        this.loginFrame = loginFrame;
    }

    public static MainWindow getMainWindow() {
        return mainWindow;
    }

    public static void setUserInfo(){
        mainWindow.setUser(currentUser);
        mainWindow.updateUserNameLabel();
        mainWindow.restoreCalendar();
    }

    public void setMainWindow(MainWindow mainWindow) {
        this.mainWindow = mainWindow;
    }

    public static User getCurrentUser() {
        return currentUser;
    }

    public static void setCurrentUser(User user) {
        Controller.currentUser = user;
    }

    public static TrainingSignUp getTrainingSignUp() {
        return trainingSignUp;
    }

    public static void setTrainingSignUp(TrainingSignUp trainingSignUp) {
        Controller.trainingSignUp = trainingSignUp;
    }
}
