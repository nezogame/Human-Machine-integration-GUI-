package MyPackage;

import javax.swing.*;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class PasswordDB {
    private static HashMap<String,User> userInfo = new HashMap<String,User>();

    static public void addUser(User newUser){
        if(userInfo.containsKey(newUser.getUsername())){
            return;
        }
        userInfo.put(newUser.getUsername(), newUser);
    }

    static public void addUser(User ... newUsers){
        for (var newUser : newUsers) {
            if(userInfo.containsKey(newUser.getUsername())){
                return;
            }
            userInfo.put(newUser.getUsername(), newUser);
        }

    }

    public static User getUser(String username) {
        return userInfo.get(username);
    }

    public static List<User> getCoaches() {
        return userInfo.values().stream()
                .filter(User::isCoach)
                .toList();
    }

    public static boolean isUserExist(User user){
        User storedUser = getUser(user.getUsername());

        if(!userInfo.containsKey(user.getUsername())){
            return false;
        }
        if(validateCoach(storedUser)){
            user.setCoach(true);
        }
        if(!(user.checkPassword(storedUser))){
            return false;
        }
        return true;
    }

    public static boolean textFieldIsEmpty(JTextField textField) {
        if(textField.getText().equals("")){
            return true;
        }
        return false;
    }

    public static void changeEnabled(JButton button, boolean enable){
        button.setEnabled(enable);
    }


    public static boolean validateCoach(User user){
        return user.isCoach();
    }

    public static HashMap<String, User> getUserInfo() {
        return userInfo;
    }

    public static void setUserInfo(HashMap<String, User> userInfo) {
        PasswordDB.userInfo = userInfo;
    }
}
