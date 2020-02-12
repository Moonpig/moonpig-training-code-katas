import org.junit.Test
import org.assertj.core.api.Assertions.assertThat

class ExampleTest {

    @Test
    internal fun shouldAddTwoNumbers() {
        val result = add(2, 3)

        assertThat(result).isEqualTo(5)
    }
}