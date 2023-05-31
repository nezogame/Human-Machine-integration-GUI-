package MyPackage;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.net.URI;

public class SignUp extends JFrame {
    private JPanel signUpPanel;
    private JPanel leftPanel;
    private JPanel middlePanel;
    private JLabel welcomeLabel;
    private JLabel logoLabel;
    private JTextField userNameTField;
    private JPasswordField userPasswordPField;
    private JButton signUpButton;
    private JCheckBox maleCheckBox;
    private JCheckBox femaleCheckBox;
    private JLabel genderLabel;
    private JButton cancelButton;
    private JLabel userExistLabel;
    private JButton documentationButton;
    private JButton usernameDocButton;
    private JButton pasDocButton;
    private JButton genDocButton;
    private JButton signUpDocButton;
    private JButton canDocButton;

    public SignUp() {

        setContentPane(getSignUpPanel());
        setLocation(450, 100);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        pack();

        maleCheckBox.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                getFemaleCheckBox().setSelected(false);
            }
        });
        femaleCheckBox.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                getMaleCheckBox().setSelected(false);
            }
        });
        cancelButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                getUserNameTField().setText("");
                getUserPasswordPField().setText("");
                Controller.changeWindow(getSignUpFrame(),Controller.getLoginFrame());
            }
        });
        signUpButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                var userName = getUserNameTField().getText();
                var password = new String(getUserPasswordPField().getPassword());
                String updatedText;
                ImageIcon invalid = new ImageIcon("src/main/resources/image/without_bg_exclamation_mark_30x30.png");

                if(PasswordDB.textFieldIsEmpty(getUserNameTField()) || PasswordDB.textFieldIsEmpty(getUserPasswordPField())){
                    PasswordDB.changeEnabled(signUpButton,false);
                    getUserExistLabel().setIcon(invalid);
                    getUserExistLabel().setText("Your name or password are empty!");
                    getUserExistLabel().setVisible(true);
                    return;
                }else{
                    PasswordDB.changeEnabled(signUpButton,true);
                }

                if(PasswordDB.isUserExist(new User(userName,password))){
                    getUserExistLabel().setIcon(invalid);
                    getUserExistLabel().setText("This account already exists!");
                    getUserExistLabel().setVisible(true);
                }else{
                    User user = new User(userName,password);
                    PasswordDB.addUser();
                    getUserNameTField().setText("");
                    getUserPasswordPField().setText("");
                    Controller.setCurrentUser(user);
                    Controller.setUserInfo();
                    Controller.changeWindow(getSignUpFrame(),Controller.getMainWindow());
                }
            }
        });
        userNameTField.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

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
        getSignUpPanel().getInputMap(JComponent.WHEN_IN_FOCUSED_WINDOW).put(keyStroke, "help");
        getSignUpPanel().getActionMap().put("help", helpAction);
        documentationButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic1.html#%D0%A0%D0%B5%D1%94%D1%81%D1%82%D1%80%D0%B0%D1%86%D1%96%D1%8F"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
        signUpDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Sign_up"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
        pasDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Password"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
        usernameDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#User_name"));
                } catch (Exception exception) {
                    exception.printStackTrace();
                }
            }
        });
    }

    public SignUp getSignUpFrame(){
        return this;
    }

    public JPanel getSignUpPanel() {
        return signUpPanel;
    }

    public void setSignUpPanel(JPanel signUpPanel) {
        this.signUpPanel = signUpPanel;
    }

    public JPanel getLeftPanel() {
        return leftPanel;
    }

    public void setLeftPanel(JPanel leftPanel) {
        this.leftPanel = leftPanel;
    }

    public JPanel getMiddlePanel() {
        return middlePanel;
    }

    public void setMiddlePanel(JPanel middlePanel) {
        this.middlePanel = middlePanel;
    }

    public JLabel getWelcomeLabel() {
        return welcomeLabel;
    }

    public void setWelcomeLabel(JLabel welcomeLabel) {
        this.welcomeLabel = welcomeLabel;
    }

    public JLabel getLogoLabel() {
        return logoLabel;
    }

    public void setLogoLabel(JLabel logoLabel) {
        this.logoLabel = logoLabel;
    }

    public JTextField getUserNameTField() {
        return userNameTField;
    }

    public void setUserNameTField(JTextField userNameTField) {
        this.userNameTField = userNameTField;
    }

    public JPasswordField getUserPasswordPField() {
        return userPasswordPField;
    }

    public void setUserPasswordPField(JPasswordField userPasswordPField) {
        this.userPasswordPField = userPasswordPField;
    }

    public JButton getSignUpButton() {
        return signUpButton;
    }

    public void setSignUpButton(JButton signUpButton) {
        this.signUpButton = signUpButton;
    }

    public JCheckBox getMaleCheckBox() {
        return maleCheckBox;
    }

    public void setMaleCheckBox(JCheckBox maleCheckBox) {
        this.maleCheckBox = maleCheckBox;
    }

    public JCheckBox getFemaleCheckBox() {
        return femaleCheckBox;
    }

    public void setFemaleCheckBox(JCheckBox femaleCheckBox) {
        this.femaleCheckBox = femaleCheckBox;
    }

    public JLabel getGenderLabel() {
        return genderLabel;
    }

    public void setGenderLabel(JLabel genderLabel) {
        this.genderLabel = genderLabel;
    }

    public JButton getCancelButton() {
        return cancelButton;
    }

    public void setCancelButton(JButton cancelButton) {
        this.cancelButton = cancelButton;
    }

    public JLabel getUserExistLabel() {
        return userExistLabel;
    }

    public void setUserExistLabel(JLabel userExistLabel) {
        this.userExistLabel = userExistLabel;
    }
}
