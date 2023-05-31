package MyPackage;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.net.URI;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.Month;
import java.time.YearMonth;
import java.time.format.DateTimeFormatter;
import java.util.List;
import java.util.Objects;

public class TrainingSignUp extends JFrame {
    private JPanel joinTrainingJPanel;
    private JTextArea joinTArea;
    private JTextArea chosenTArea;
    private JPanel topJPanel;
    private JPanel bottomJPanel;
    private JPanel middleJPanel;
    private JComboBox timeBox;
    private JComboBox trainerBox;
    private JLabel trainerLabel;
    private JLabel timeLabel;
    private JLabel dateLabel;
    private JComboBox dateBox;
    private JButton joinButton;
    private JComboBox trainingPlanJCBox;
    private JLabel invalidTimeLabel;
    private YearMonth yearMonthObject;
    private LocalDate today;
    private Month currentMonth;
    private int currentDay ;
    private List<User> coach;

    public TrainingSignUp() {
        String updatedText;
        setContentPane(getJoinTrainingJPanel());
        setLocation(423, 243);
        setSize(500, 240);
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        today = LocalDate.now();
        currentMonth = today.getMonth();
        currentDay = today.getDayOfMonth();
        yearMonthObject = YearMonth.of(today.getYear(),currentMonth.getValue()+1);
        addDate();
        addWorkTime();
        addCoach();


        joinButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                var searched = "chosen";
                var training = getChosenTArea().getText();
                var coach = getTrainerBox().getSelectedItem().toString();
                var time = getTimeBox().getSelectedItem().toString();
                var date = getDateBox().getSelectedItem().toString();
                var index = training.indexOf(searched)+searched.length();
                User user = Controller.getMainWindow().getUser();
                training = training.substring(index);

                Controller.getMainWindow().addRow(training,coach,date,time);
                setVisible(false);
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
        getJoinTrainingJPanel().getInputMap(JComponent.WHEN_IN_FOCUSED_WINDOW).put(keyStroke, "help");
        getJoinTrainingJPanel().getActionMap().put("help", helpAction);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        TrainingSignUp that = (TrainingSignUp) o;
        return Objects.equals(joinTrainingJPanel, that.joinTrainingJPanel) && Objects.equals(joinTArea, that.joinTArea)
                && Objects.equals(chosenTArea, that.chosenTArea) && Objects.equals(topJPanel, that.topJPanel)
                && Objects.equals(bottomJPanel, that.bottomJPanel) && Objects.equals(middleJPanel, that.middleJPanel)
                && Objects.equals(timeBox, that.timeBox) && Objects.equals(trainerBox, that.trainerBox)
                && Objects.equals(trainerLabel, that.trainerLabel) && Objects.equals(timeLabel, that.timeLabel)
                && Objects.equals(dateLabel, that.dateLabel) && Objects.equals(dateBox, that.dateBox)
                && Objects.equals(joinButton, that.joinButton);
    }

    @Override
    public int hashCode() {
        return Objects.hash(joinTrainingJPanel, joinTArea, chosenTArea, topJPanel, bottomJPanel, middleJPanel
                , timeBox, trainerBox, trainerLabel, timeLabel, dateLabel, dateBox, joinButton);
    }

    public JPanel getJoinTrainingJPanel() {
        return joinTrainingJPanel;
    }
 /*   private boolean validateDate(LocalTime time){
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("h:mm a");
        LocalTime now = LocalTime.now();
        now.format(formatter);
        if(now.isAfter(time)){
            return true;
        }
        return false;
    }*/

    private void addDate(){

        int daysInNextMonth = yearMonthObject.lengthOfMonth();
        for (int i = 1; i <= daysInNextMonth; i++) {
            LocalDate date = today.plusDays(i);
            Month month = date.getMonth();
            int day = date.getDayOfMonth();
            dateBox.addItem(month.toString() + " " + day);
        }
    }

    private void addWorkTime(){
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("h:mm a");

        LocalTime time = LocalTime.of(8, 0);
        while (time.isBefore(LocalTime.of(17, 31))) {
            timeBox.addItem(time.format(formatter));
            time = time.plusMinutes(30);
        }
    }

    private void addCoach(){
        for (var coach:PasswordDB.getCoaches()) {
            trainerBox.addItem(coach.getUsername());
        }
    }

    protected void coachTrainings(User user){
        for (var training : user.getCoachTrainings().keySet()) {
            trainingPlanJCBox.addItem(training);
        }
    }

    public void showMyConcept(boolean show) {
        trainingPlanJCBox.setVisible(show);
    }

    public void setJoinTrainingJPanel(JPanel joinTrainingJPanel) {
        this.joinTrainingJPanel = joinTrainingJPanel;
    }

    public JTextArea getJoinTArea() {
        return joinTArea;
    }

    public void setJoinTArea(JTextArea joinTArea) {
        this.joinTArea = joinTArea;
    }

    public JTextArea getChosenTArea() {
        return chosenTArea;
    }

    public void setChosenTArea(String chosenTArea) {
        this.chosenTArea.setText(chosenTArea);
    }

    public JPanel getTopJPanel() {
        return topJPanel;
    }

    public void setTopJPanel(JPanel topJPanel) {
        this.topJPanel = topJPanel;
    }

    public JPanel getBottomJPanel() {
        return bottomJPanel;
    }

    public void setBottomJPanel(JPanel bottomJPanel) {
        this.bottomJPanel = bottomJPanel;
    }

    public JPanel getMiddleJPanel() {
        return middleJPanel;
    }

    public void setMiddleJPanel(JPanel middleJPanel) {
        this.middleJPanel = middleJPanel;
    }

    public JComboBox getTimeBox() {
        return timeBox;
    }

    public void setTimeBox(JComboBox timeBox) {
        this.timeBox = timeBox;
    }

    public JComboBox getTrainerBox() {
        return trainerBox;
    }

    public void setTrainerBox(JComboBox trainerBox) {
        this.trainerBox = trainerBox;
    }

    public JLabel getTrainerLabel() {
        return trainerLabel;
    }

    public void setTrainerLabel(JLabel trainerLabel) {
        this.trainerLabel = trainerLabel;
    }

    public JLabel getTimeLabel() {
        return timeLabel;
    }

    public void setTimeLabel(JLabel timeLabel) {
        this.timeLabel = timeLabel;
    }

    public JLabel getDateLabel() {
        return dateLabel;
    }

    public void setDateLabel(JLabel dateLabel) {
        this.dateLabel = dateLabel;
    }

    public JComboBox getDateBox() {
        return dateBox;
    }

    public void setDateBox(JComboBox dateBox) {
        this.dateBox = dateBox;
    }

    public JButton getJoinButton() {
        return joinButton;
    }

    public void setJoinButton(JButton joinButton) {
        this.joinButton = joinButton;
    }

    public void setChosenTArea(JTextArea chosenTArea) {
        this.chosenTArea = chosenTArea;
    }

    public JLabel getInvalidTimeLabel() {
        return invalidTimeLabel;
    }

    public void setInvalidTimeLabel(JLabel invalidTimeLabel) {
        this.invalidTimeLabel = invalidTimeLabel;
    }

    public YearMonth getYearMonthObject() {
        return yearMonthObject;
    }

    public void setYearMonthObject(YearMonth yearMonthObject) {
        this.yearMonthObject = yearMonthObject;
    }

    public LocalDate getToday() {
        return today;
    }

    public void setToday(LocalDate today) {
        this.today = today;
    }

    public Month getCurrentMonth() {
        return currentMonth;
    }

    public void setCurrentMonth(Month currentMonth) {
        this.currentMonth = currentMonth;
    }

    public int getCurrentDay() {
        return currentDay;
    }

    public void setCurrentDay(int currentDay) {
        this.currentDay = currentDay;
    }

    public List<User> getCoach() {
        return coach;
    }

    public void setCoach(List<User> coach) {
        this.coach = coach;
    }

    public JComboBox getTrainingPalnJCBox() {
        return trainingPlanJCBox;
    }

    public void setTrainingPalnJCBox(JComboBox trainingPalnJCBox) {
        this.trainingPlanJCBox = trainingPalnJCBox;
    }
}
