package MyPackage;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.net.URI;

public class Login extends JFrame implements ActionListener {

    private JPanel panelStart;
    private JPanel bottomPanel;
    private JPanel topPanel;
    private JPanel middlePanel;
    private JPanel leftPanel;
    private JPanel rightPanel;
    private JTextField userNameTField;
    private JPasswordField passwordPField;
    private JLabel userNameLabel;
    private JLabel passwordLabel;
    private JButton loginButton;
    private JLabel dummyLabel;
    private JButton forgotYourPasswordButton;
    private JButton signUpButton;
    private JLabel signInLabel;
    private JLabel validateLabel;
    private JButton documentationButton;
    private JButton usernameButton;
    private JButton loginAnchorButton;


    public Login() {

        setContentPane(getPanelStart());
        setLocation(300, 150);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        pack();

        signUpButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                getUserNameTField().setText("");
                getPasswordPField().setText("");
                Controller.changeWindow(getLoginFrame(), Controller.getSignUpFrame());
            }
        });
        loginButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                User user;
                var userName = userNameTField.getText();
                var password = new String(passwordPField.getPassword());

                String updatedText;
                ImageIcon invalid = new ImageIcon("src/main/resources/image/without_bg_exclamation_mark_30x30.png");

                if(PasswordDB.textFieldIsEmpty(getUserNameTField()) ||
                        PasswordDB.textFieldIsEmpty(getPasswordPField())){
                    PasswordDB.changeEnabled(loginButton,false);
                    getValidateLabel().setIcon(invalid);
                    getValidateLabel().setText("Your name or password are empty!");
                    getValidateLabel().setVisible(true);
                    return;
                }else{
                    PasswordDB.changeEnabled(loginButton,true);
                }


                if(PasswordDB.isUserExist( new User(userName,password))){
                    user = PasswordDB.getUser(userName);
                    userNameTField.setText("");
                    passwordPField.setText("");
                    Controller.setCurrentUser(user);
                    Controller.setUserInfo();
                    Controller.changeWindow(getLoginFrame(),Controller.getMainWindow());
                    if(user.isCoach()){
                        Controller.getMainWindow().addUserOnTraining();
                        Controller.getMainWindow().showCoachPanel();
                    }
                }else{
                    validateLabel.setIcon(invalid);
                    validateLabel.setText("Login failed! Please check your username or password!");
                    validateLabel.setVisible(true);
                }
            }
        });
        documentationButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic.html#%D0%90%D0%B2%D1%82%D0%BE%D1%80%D0%B8%D0%B7%D0%B0%D1%86%D1%96%D1%8F"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });

        KeyStroke keyStroke = KeyStroke.getKeyStroke(KeyEvent.VK_F1, 0);
        Action helpAction = new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        };
        getPanelStart().getInputMap(JComponent.WHEN_IN_FOCUSED_WINDOW).put(keyStroke, "help");
        getPanelStart().getActionMap().put("help", helpAction);
        usernameButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#User_name"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
        loginAnchorButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Password"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
    }


    public Login getLoginFrame(){
        return this;
    }

    public void setPosition(JLabel label,int x,int y){
        label.setLocation(x,y);
    }

    public JPanel getPanelStart() {
        return panelStart;
    }

    public void setPanelStart(JPanel panelStart) {
        this.panelStart = panelStart;
    }

    public JPanel getBottomPanel() {
        return bottomPanel;
    }

    public void setBottomPanel(JPanel bottomPanel) {
        this.bottomPanel = bottomPanel;
    }

    public JPanel getTopPanel() {
        return topPanel;
    }

    public void setTopPanel(JPanel topPanel) {
        this.topPanel = topPanel;
    }

    public JPanel getMiddlePanel() {
        return middlePanel;
    }

    public void setMiddlePanel(JPanel middlePanel) {
        this.middlePanel = middlePanel;
    }

    public JPanel getLeftPanel() {
        return leftPanel;
    }

    public void setLeftPanel(JPanel leftPanel) {
        this.leftPanel = leftPanel;
    }

    public JPanel getRightPanel() {
        return rightPanel;
    }

    public void setRightPanel(JPanel rightPanel) {
        this.rightPanel = rightPanel;
    }

    public JTextField getUserNameTField() {
        return userNameTField;
    }

    public void setUserNameTField(JTextField userNameTField) {
        this.userNameTField = userNameTField;
    }

    public JPasswordField getPasswordPField() {
        return passwordPField;
    }

    public void setPasswordPField(JPasswordField passwordPField) {
        this.passwordPField = passwordPField;
    }

    public JLabel getUserNameLabel() {
        return userNameLabel;
    }

    public void setUserNameLabel(JLabel userNameLabel) {
        this.userNameLabel = userNameLabel;
    }

    public JLabel getPasswordLabel() {
        return passwordLabel;
    }

    public void setPasswordLabel(JLabel passwordLabel) {
        this.passwordLabel = passwordLabel;
    }

    public JButton getLoginButton() {
        return loginButton;
    }

    public void setLoginButton(JButton loginButton) {
        this.loginButton = loginButton;
    }

    public JLabel getDummyLabel() {
        return dummyLabel;
    }

    public void setDummyLabel(JLabel dummyLabel) {
        this.dummyLabel = dummyLabel;
    }

    public JButton getForgotYourPasswordButton() {
        return forgotYourPasswordButton;
    }

    public void setForgotYourPasswordButton(JButton forgotYourPasswordButton) {
        this.forgotYourPasswordButton = forgotYourPasswordButton;
    }

    public JButton getSignUpButton() {
        return signUpButton;
    }

    public void setSignUpButton(JButton signUpButton) {
        this.signUpButton = signUpButton;
    }

    public JLabel getSignInLabel() {
        return signInLabel;
    }

    public void setSignInLabel(JLabel signInLabel) {
        this.signInLabel = signInLabel;
    }

    public JLabel getValidateLabel() {
        return validateLabel;
    }

    public void setValidateLabel(JLabel validateLabel) {
        this.validateLabel = validateLabel;
    }

    @Override
    public void actionPerformed(ActionEvent e) {



    }
}
